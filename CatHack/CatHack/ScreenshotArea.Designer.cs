
namespace CatHack
{
    partial class ScreenshotArea
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
            this.panelDrag = new System.Windows.Forms.Panel();
            this.capureThis = new System.Windows.Forms.Button();
            this.panelDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDrag
            // 
            this.panelDrag.AccessibleName = "";
            this.panelDrag.Controls.Add(this.capureThis);
            this.panelDrag.Location = new System.Drawing.Point(12, 12);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(776, 426);
            this.panelDrag.TabIndex = 0;
            this.panelDrag.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // capureThis
            // 
            this.capureThis.Location = new System.Drawing.Point(285, 133);
            this.capureThis.Name = "capureThis";
            this.capureThis.Size = new System.Drawing.Size(75, 23);
            this.capureThis.TabIndex = 0;
            this.capureThis.Text = "button1";
            this.capureThis.UseVisualStyleBackColor = true;
            this.capureThis.Click += new System.EventHandler(this.captureThis_Click);
            this.capureThis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.captureThis_KeyDown);
            // 
            // ScreenshotArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenshotArea";
            this.Text = "ScreenshotArea";
            this.panelDrag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.Button capureThis;
    }
}