
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveUserPing));
            this.button1 = new System.Windows.Forms.Button();
            this.imageCapture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imageCapture
            // 
            this.imageCapture.Location = new System.Drawing.Point(294, 170);
            this.imageCapture.Name = "imageCapture";
            this.imageCapture.Size = new System.Drawing.Size(100, 50);
            this.imageCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imageCapture.TabIndex = 1;
            this.imageCapture.TabStop = false;
            // 
            // SaveUserPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageCapture);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaveUserPing";
            this.Text = "SaveUserPing";
            ((System.ComponentModel.ISupportInitialize)(this.imageCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imageCapture;
    }
}