using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace NuGet.Tessnet2.src
{
    public class Ocr
    {
        ManualResetEvent _mEvent;
        private readonly string _tessdataPath;

        public void DumpResult(List<tessnet2.Word> result)
        {
            foreach (var word in result)
                Console.WriteLine("{0} : {1}", word.Confidence, word.Text);
        }

        public List<tessnet2.Word> DoOcrNormal(Bitmap image, string lang)
        {
            var ocr = new tessnet2.Tesseract();
            ocr.Init(_tessdataPath, lang, false);
            var result = ocr.DoOCR(image, Rectangle.Empty);
            DumpResult(result);
            return result;
        }

        public void DoOcrMultiThred(Bitmap image, string lang)
        {
            var ocr = new tessnet2.Tesseract();
            ocr.Init(_tessdataPath, lang, false);
            // If the OcrDone delegate is not null then this'll be the multithreaded version
            ocr.OcrDone = Finished;
            // For event to work, must use the multithreaded version
            ocr.ProgressEvent += OcrProgressEvent;
            _mEvent = new ManualResetEvent(false);
            ocr.DoOCR(image, Rectangle.Empty);
            // Wait here it's finished
            _mEvent.WaitOne();
        }

        public void Finished(List<tessnet2.Word> result)
        {
            DumpResult(result);
            _mEvent.Set();
        }

        static void OcrProgressEvent(int percent)
        {
            Console.WriteLine("{0}% progression", percent);
        }

        public Ocr(string tessdataPath)
        {
            _tessdataPath = tessdataPath;
        }
    }
}
