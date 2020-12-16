
namespace CatHack
{
    partial class SaveUserPing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCapture
            // 
            this.imageCapture.Location = new System.Drawing.Point(290, 169);
            this.imageCapture.Name = "imageCapture";
            this.imageCapture.Size = new System.Drawing.Size(100, 50);
            this.imageCapture.TabIndex = 0;
            this.imageCapture.TabStop = false;
            // 
            // SaveUserPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageCapture);
            this.Name = "SaveUserPing";
            this.Text = "SaveUserPing";
            ((System.ComponentModel.ISupportInitialize)(this.imageCapture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageCapture;
    }
}