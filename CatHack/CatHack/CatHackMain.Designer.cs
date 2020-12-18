
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatHackMain));
            this.checkSpaceGlideBox = new System.Windows.Forms.CheckBox();
            this.checkKiteModeBox = new System.Windows.Forms.CheckBox();
            this.thresholdCheckBox = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.userPingScreenshotCheckBox = new System.Windows.Forms.CheckBox();
            this.attackSpeedScreenshotCheckBox = new System.Windows.Forms.CheckBox();
            this.keycodeLink = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cathackStart = new System.Windows.Forms.CheckBox();
            this.championBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.useAttackSpeedCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.useUserPingCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.useUserPingCheckBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.useAttackSpeedCheckBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.userPingScreenshotCheckBox);
            this.panel2.Controls.Add(this.attackSpeedScreenshotCheckBox);
            this.panel2.Controls.Add(this.keycodeLink);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(21, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 272);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(55, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Save User Ping Box? (X, Y, W, H)";
            // 
            // userPingScreenshotCheckBox
            // 
            this.userPingScreenshotCheckBox.AutoSize = true;
            this.userPingScreenshotCheckBox.Location = new System.Drawing.Point(26, 238);
            this.userPingScreenshotCheckBox.Name = "userPingScreenshotCheckBox";
            this.userPingScreenshotCheckBox.Size = new System.Drawing.Size(15, 14);
            this.userPingScreenshotCheckBox.TabIndex = 16;
            this.userPingScreenshotCheckBox.UseVisualStyleBackColor = true;
            this.userPingScreenshotCheckBox.CheckedChanged += new System.EventHandler(this.userPingScreenshotCheckBox_CheckedChanged);
            // 
            // attackSpeedScreenshotCheckBox
            // 
            this.attackSpeedScreenshotCheckBox.AutoSize = true;
            this.attackSpeedScreenshotCheckBox.Location = new System.Drawing.Point(26, 205);
            this.attackSpeedScreenshotCheckBox.Name = "attackSpeedScreenshotCheckBox";
            this.attackSpeedScreenshotCheckBox.Size = new System.Drawing.Size(15, 14);
            this.attackSpeedScreenshotCheckBox.TabIndex = 15;
            this.attackSpeedScreenshotCheckBox.UseVisualStyleBackColor = true;
            this.attackSpeedScreenshotCheckBox.CheckedChanged += new System.EventHandler(this.attackSpeedScreenshotCheckBox_CheckedChanged);
            // 
            // keycodeLink
            // 
            this.keycodeLink.AutoSize = true;
            this.keycodeLink.LinkColor = System.Drawing.Color.White;
            this.keycodeLink.Location = new System.Drawing.Point(55, 56);
            this.keycodeLink.Name = "keycodeLink";
            this.keycodeLink.Size = new System.Drawing.Size(212, 13);
            this.keycodeLink.TabIndex = 8;
            this.keycodeLink.TabStop = true;
            this.keycodeLink.Text = "OrbWalk Keycode (What key to start kiting)";
            this.keycodeLink.UseWaitCursor = true;
            this.keycodeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.keycodeLink_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(55, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Save Attack Speed Box? (X, Y, W, H)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(55, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(55, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "AS Threshold (Orb Walk at target AS)";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(33, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(33, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.userOrbWalkBind_TextChanged);
            // 
            // cathackStart
            // 
            this.cathackStart.AutoSize = true;
            this.cathackStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cathackStart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cathackStart.Location = new System.Drawing.Point(100, 208);
            this.cathackStart.Name = "cathackStart";
            this.cathackStart.Size = new System.Drawing.Size(110, 17);
            this.cathackStart.TabIndex = 6;
            this.cathackStart.Text = "Activate CatHack";
            this.cathackStart.UseVisualStyleBackColor = false;
            this.cathackStart.CheckedChanged += new System.EventHandler(this.cathackStart_CheckedChanged);
            // 
            // championBox
            // 
            this.championBox.BackColor = System.Drawing.Color.Tomato;
            this.championBox.FormattingEnabled = true;
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
            "Samira",
            "Quinn",
            "Sivir",
            "Teemo",
            "Tristana",
            "Twitch",
            "Twisted Fate",
            "Varus",
            "Vayne",
            "Xayah"});
            this.championBox.Location = new System.Drawing.Point(14, 42);
            this.championBox.Name = "championBox";
            this.championBox.Size = new System.Drawing.Size(353, 21);
            this.championBox.TabIndex = 7;
            this.championBox.SelectionChangeCommitted += new System.EventHandler(this.championBox_SelectionChangeCommitted);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.championBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(341, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 467);
            this.panel3.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.Peru;
            this.label6.Location = new System.Drawing.Point(156, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Champion Selector";
            // 
            // useAttackSpeedCheckBox
            // 
            this.useAttackSpeedCheckBox.AutoSize = true;
            this.useAttackSpeedCheckBox.Location = new System.Drawing.Point(26, 146);
            this.useAttackSpeedCheckBox.Name = "useAttackSpeedCheckBox";
            this.useAttackSpeedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.useAttackSpeedCheckBox.TabIndex = 18;
            this.useAttackSpeedCheckBox.UseVisualStyleBackColor = true;
            this.useAttackSpeedCheckBox.CheckedChanged += new System.EventHandler(this.useAttackSpeedCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(55, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Use Saved Attack Speed Box?";
            // 
            // useUserPingCheckBox
            // 
            this.useUserPingCheckBox.AutoSize = true;
            this.useUserPingCheckBox.Location = new System.Drawing.Point(26, 175);
            this.useUserPingCheckBox.Name = "useUserPingCheckBox";
            this.useUserPingCheckBox.Size = new System.Drawing.Size(15, 14);
            this.useUserPingCheckBox.TabIndex = 20;
            this.useUserPingCheckBox.UseVisualStyleBackColor = true;
            this.useUserPingCheckBox.CheckedChanged += new System.EventHandler(this.useUserPingCheckBox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(55, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Use Saved User Ping Box?";
            // 
            // CatHackMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(748, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cathackStart);
            this.Controls.Add(this.checkKiteModeBox);
            this.Controls.Add(this.thresholdCheckBox);
            this.Controls.Add(this.checkSpaceGlideBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatHackMain";
            this.Text = "CatHackMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cathackStart;
        private System.Windows.Forms.ComboBox championBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel keycodeLink;
        private System.Windows.Forms.CheckBox attackSpeedScreenshotCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox userPingScreenshotCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox useUserPingCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox useAttackSpeedCheckBox;
    }
}