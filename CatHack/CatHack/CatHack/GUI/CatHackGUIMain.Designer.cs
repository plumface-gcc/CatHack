
namespace CatHack
{
    partial class CatHackGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.playerLabel = new System.Windows.Forms.Label();
            this.PlayerPicBox = new System.Windows.Forms.PictureBox();
            this.champLabel = new System.Windows.Forms.Label();
            this.ChampionsPicBox = new System.Windows.Forms.PictureBox();
            this.orbLabel = new System.Windows.Forms.Label();
            this.OrbwalkingPicBox = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampionsPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrbwalkingPicBox)).BeginInit();
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
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(263, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hub";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.playerLabel);
            this.panel5.Controls.Add(this.PlayerPicBox);
            this.panel5.Controls.Add(this.champLabel);
            this.panel5.Controls.Add(this.ChampionsPicBox);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.orbLabel);
            this.panel5.Controls.Add(this.OrbwalkingPicBox);
            this.panel5.Location = new System.Drawing.Point(0, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(569, 230);
            this.panel5.TabIndex = 6;
            // 
            // playerLabel
            // 
            this.playerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.playerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.playerLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.playerLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playerLabel.Location = new System.Drawing.Point(403, 162);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(115, 33);
            this.playerLabel.TabIndex = 13;
            this.playerLabel.Text = "Player";
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerPicBox
            // 
            this.PlayerPicBox.Image = global::CatHack.Properties.Resources.imageedit_7_8844802025;
            this.PlayerPicBox.Location = new System.Drawing.Point(377, 54);
            this.PlayerPicBox.Name = "PlayerPicBox";
            this.PlayerPicBox.Size = new System.Drawing.Size(174, 105);
            this.PlayerPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerPicBox.TabIndex = 12;
            this.PlayerPicBox.TabStop = false;
            this.PlayerPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayerPicBox_Paint);
            this.PlayerPicBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayerPicBox_MouseClick);
            this.PlayerPicBox.MouseEnter += new System.EventHandler(this.PlayerPicBox_MouseEnter);
            this.PlayerPicBox.MouseLeave += new System.EventHandler(this.PlayerPicBox_MouseLeave);
            // 
            // champLabel
            // 
            this.champLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.champLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.champLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.champLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.champLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.champLabel.Location = new System.Drawing.Point(232, 162);
            this.champLabel.Name = "champLabel";
            this.champLabel.Size = new System.Drawing.Size(115, 25);
            this.champLabel.TabIndex = 11;
            this.champLabel.Text = "Champions";
            this.champLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChampionsPicBox
            // 
            this.ChampionsPicBox.Image = global::CatHack.Properties.Resources.imageedit_15_6760091815;
            this.ChampionsPicBox.Location = new System.Drawing.Point(196, 54);
            this.ChampionsPicBox.Name = "ChampionsPicBox";
            this.ChampionsPicBox.Size = new System.Drawing.Size(180, 105);
            this.ChampionsPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChampionsPicBox.TabIndex = 10;
            this.ChampionsPicBox.TabStop = false;
            this.ChampionsPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ChampionsPicBox_Paint);
            this.ChampionsPicBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChampionsPicBox_MouseClick);
            this.ChampionsPicBox.MouseEnter += new System.EventHandler(this.ChampionsPicBox_MouseEnter);
            this.ChampionsPicBox.MouseLeave += new System.EventHandler(this.ChampionsPicBox_MouseLeave);
            // 
            // orbLabel
            // 
            this.orbLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orbLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.orbLabel.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orbLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.orbLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.orbLabel.Location = new System.Drawing.Point(47, 162);
            this.orbLabel.Name = "orbLabel";
            this.orbLabel.Size = new System.Drawing.Size(115, 25);
            this.orbLabel.TabIndex = 7;
            this.orbLabel.Text = "Orbwalking";
            this.orbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrbwalkingPicBox
            // 
            this.OrbwalkingPicBox.Image = global::CatHack.Properties.Resources.imageedit_11_2080037162;
            this.OrbwalkingPicBox.Location = new System.Drawing.Point(15, 54);
            this.OrbwalkingPicBox.Name = "OrbwalkingPicBox";
            this.OrbwalkingPicBox.Size = new System.Drawing.Size(181, 105);
            this.OrbwalkingPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OrbwalkingPicBox.TabIndex = 0;
            this.OrbwalkingPicBox.TabStop = false;
            this.OrbwalkingPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OrbwalkingPicBox_Paint);
            this.OrbwalkingPicBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OrbwalkingPicBox_MouseClick);
            this.OrbwalkingPicBox.MouseEnter += new System.EventHandler(this.OrbwalkingPicBox_MouseEnter);
            this.OrbwalkingPicBox.MouseLeave += new System.EventHandler(this.OrbwalkingPicBox_MouseLeave);
            // 
            // CatHackGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(568, 238);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatHackGUI";
            this.Text = "CatHackGUI";
            this.Load += new System.EventHandler(this.CatHackGUI_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChampionsPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrbwalkingPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox OrbwalkingPicBox;
        private System.Windows.Forms.Label orbLabel;
        private System.Windows.Forms.PictureBox ChampionsPicBox;
        private System.Windows.Forms.Label champLabel;
        private System.Windows.Forms.PictureBox PlayerPicBox;
        private System.Windows.Forms.Label playerLabel;
    }
}