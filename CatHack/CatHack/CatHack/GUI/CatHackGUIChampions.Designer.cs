
namespace CatHack.GUI
{
    partial class CatHackGUIChampions
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.windupModifierLabel = new System.Windows.Forms.Label();
            this.baseWindupTimeLabel = new System.Windows.Forms.Label();
            this.windupPercentLabel = new System.Windows.Forms.Label();
            this.championPic = new System.Windows.Forms.PictureBox();
            this.championBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.championPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 10);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel2.Location = new System.Drawing.Point(6, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 18);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel4.Location = new System.Drawing.Point(-3, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 301);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel3.Location = new System.Drawing.Point(557, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 301);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(77, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Champions";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.windupModifierLabel);
            this.panel5.Controls.Add(this.baseWindupTimeLabel);
            this.panel5.Controls.Add(this.windupPercentLabel);
            this.panel5.Controls.Add(this.championPic);
            this.panel5.Controls.Add(this.championBox);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(569, 230);
            this.panel5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(185, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Windup Modifier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(185, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Base Windup Percent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(185, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Windup Percent";
            // 
            // windupModifierLabel
            // 
            this.windupModifierLabel.AutoSize = true;
            this.windupModifierLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.windupModifierLabel.Location = new System.Drawing.Point(311, 169);
            this.windupModifierLabel.Name = "windupModifierLabel";
            this.windupModifierLabel.Size = new System.Drawing.Size(13, 13);
            this.windupModifierLabel.TabIndex = 14;
            this.windupModifierLabel.Text = "0";
            // 
            // baseWindupTimeLabel
            // 
            this.baseWindupTimeLabel.AutoSize = true;
            this.baseWindupTimeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.baseWindupTimeLabel.Location = new System.Drawing.Point(311, 114);
            this.baseWindupTimeLabel.Name = "baseWindupTimeLabel";
            this.baseWindupTimeLabel.Size = new System.Drawing.Size(13, 13);
            this.baseWindupTimeLabel.TabIndex = 13;
            this.baseWindupTimeLabel.Text = "0";
            // 
            // windupPercentLabel
            // 
            this.windupPercentLabel.AutoSize = true;
            this.windupPercentLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.windupPercentLabel.Location = new System.Drawing.Point(311, 62);
            this.windupPercentLabel.Name = "windupPercentLabel";
            this.windupPercentLabel.Size = new System.Drawing.Size(13, 13);
            this.windupPercentLabel.TabIndex = 12;
            this.windupPercentLabel.Text = "0";
            // 
            // championPic
            // 
            this.championPic.Image = global::CatHack.Properties.Resources.rsz_1mak_logo_2_nobg;
            this.championPic.Location = new System.Drawing.Point(29, 62);
            this.championPic.Name = "championPic";
            this.championPic.Size = new System.Drawing.Size(136, 120);
            this.championPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.championPic.TabIndex = 8;
            this.championPic.TabStop = false;
            // 
            // championBox
            // 
            this.championBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.championBox.DropDownHeight = 50;
            this.championBox.ForeColor = System.Drawing.Color.Gray;
            this.championBox.FormattingEnabled = true;
            this.championBox.IntegralHeight = false;
            this.championBox.Items.AddRange(new object[] {
            "Aphelios",
            "Ashe",
            "Azir",
            "Bard",
            "Caitlyn",
            "Corki",
            "Draven",
            "Ezreal",
            "Gnar",
            "Jayce",
            "Jinx",
            "Kai\'Sa",
            "Kalista",
            "Kayle",
            "Kennen",
            "Kindred",
            "Kog\'Maw",
            "Lucian",
            "Miss Fortune",
            "Neeko",
            "Quinn",
            "Samira",
            "Sivir",
            "Soraka",
            "Teemo",
            "Tristana",
            "Twisted Fate",
            "Twitch",
            "Varus",
            "Vayne",
            "Xayah",
            "Zilean"});
            this.championBox.Location = new System.Drawing.Point(363, 59);
            this.championBox.MaxDropDownItems = 12;
            this.championBox.Name = "championBox";
            this.championBox.Size = new System.Drawing.Size(181, 21);
            this.championBox.Sorted = true;
            this.championBox.TabIndex = 7;
            this.championBox.SelectionChangeCommitted += new System.EventHandler(this.championBox_SelectionChangeCommitted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CatHack.Properties.Resources.imageedit_1_6449737234;
            this.pictureBox1.Location = new System.Drawing.Point(16, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // CatHackGUIChampions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(568, 238);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatHackGUIChampions";
            this.Text = "CatHackGUI";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.championPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox championBox;
        private System.Windows.Forms.PictureBox championPic;
        private System.Windows.Forms.Label windupPercentLabel;
        private System.Windows.Forms.Label baseWindupTimeLabel;
        private System.Windows.Forms.Label windupModifierLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}