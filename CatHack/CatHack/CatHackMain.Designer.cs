
namespace CatHack
{
    partial class CatHackMain
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
            this.checkSpaceGlideBox = new System.Windows.Forms.CheckBox();
            this.checkKiteModeBox = new System.Windows.Forms.CheckBox();
            this.thresholdCheckBox = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkSpaceGlideBox
            // 
            this.checkSpaceGlideBox.AutoSize = true;
            this.checkSpaceGlideBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkSpaceGlideBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkSpaceGlideBox.Location = new System.Drawing.Point(38, 81);
            this.checkSpaceGlideBox.Name = "checkSpaceGlideBox";
            this.checkSpaceGlideBox.Size = new System.Drawing.Size(236, 17);
            this.checkSpaceGlideBox.TabIndex = 0;
            this.checkSpaceGlideBox.Text = "Space Glide Mode (Max DPS, least spacing)";
            this.checkSpaceGlideBox.UseVisualStyleBackColor = false;
            this.checkSpaceGlideBox.CheckedChanged += new System.EventHandler(this.spaceGlideBox_CheckedChanged);
            // 
            // checkKiteModeBox
            // 
            this.checkKiteModeBox.AutoSize = true;
            this.checkKiteModeBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkKiteModeBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkKiteModeBox.Location = new System.Drawing.Point(38, 117);
            this.checkKiteModeBox.Name = "checkKiteModeBox";
            this.checkKiteModeBox.Size = new System.Drawing.Size(199, 17);
            this.checkKiteModeBox.TabIndex = 1;
            this.checkKiteModeBox.Text = "Kite Mode (Less DPS, more spacing)";
            this.checkKiteModeBox.UseVisualStyleBackColor = false;
            this.checkKiteModeBox.CheckedChanged += new System.EventHandler(this.kiteModeBox_CheckedChanged);
            // 
            // thresholdCheckBox
            // 
            this.thresholdCheckBox.AutoSize = true;
            this.thresholdCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thresholdCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.thresholdCheckBox.Location = new System.Drawing.Point(38, 153);
            this.thresholdCheckBox.Name = "thresholdCheckBox";
            this.thresholdCheckBox.Size = new System.Drawing.Size(213, 17);
            this.thresholdCheckBox.TabIndex = 2;
            this.thresholdCheckBox.Text = "ONLY enable Space Glide at > 2.50 AS";
            this.thresholdCheckBox.UseVisualStyleBackColor = false;
            this.thresholdCheckBox.CheckedChanged += new System.EventHandler(this.thresholdCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orb Walking";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(21, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 169);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(107, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(21, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 169);
            this.panel2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(55, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "AS Threshold (Orb Walk at target AS)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 122);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(55, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Orb Walk Bind (What key to start kiting)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(55, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your ping in MS (Do not use with bad ping)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CatHackMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkKiteModeBox);
            this.Controls.Add(this.thresholdCheckBox);
            this.Controls.Add(this.checkSpaceGlideBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "CatHackMain";
            this.Text = "CatHackMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkSpaceGlideBox;
        private System.Windows.Forms.CheckBox checkKiteModeBox;
        private System.Windows.Forms.CheckBox thresholdCheckBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}