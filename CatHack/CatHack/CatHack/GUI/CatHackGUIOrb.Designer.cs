
namespace CatHack.GUI
{
    partial class CatHackGUIOrb
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
            this.OrbwalkToggle = new CatHack.ToggleButton.CeLearningToggle();
            this.label5 = new System.Windows.Forms.Label();
            this.RageModeToggle = new CatHack.ToggleButton.CeLearningToggle();
            this.NormalModeToggle = new CatHack.ToggleButton.CeLearningToggle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KiteModeToggle = new CatHack.ToggleButton.CeLearningToggle();
            this.exitPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.label1.Text = "Orbwalking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.OrbwalkToggle);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.RageModeToggle);
            this.panel5.Controls.Add(this.NormalModeToggle);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.KiteModeToggle);
            this.panel5.Controls.Add(this.exitPicBox);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Location = new System.Drawing.Point(0, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(569, 230);
            this.panel5.TabIndex = 6;
            // 
            // OrbwalkToggle
            // 
            this.OrbwalkToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.OrbwalkToggle.BorderColor = System.Drawing.Color.LightGray;
            this.OrbwalkToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrbwalkToggle.ForeColor = System.Drawing.Color.White;
            this.OrbwalkToggle.IsOn = false;
            this.OrbwalkToggle.Location = new System.Drawing.Point(142, 53);
            this.OrbwalkToggle.Name = "OrbwalkToggle";
            this.OrbwalkToggle.OffColor = System.Drawing.Color.DarkGray;
            this.OrbwalkToggle.OffText = "";
            this.OrbwalkToggle.OnColor = System.Drawing.Color.Green;
            this.OrbwalkToggle.OnText = "";
            this.OrbwalkToggle.Size = new System.Drawing.Size(28, 16);
            this.OrbwalkToggle.TabIndex = 17;
            this.OrbwalkToggle.Text = "ceLearningToggle1";
            this.OrbwalkToggle.TextEnabled = true;
            this.OrbwalkToggle.sliderValueChanged += new CatHack.ToggleButton.CeLearningToggle.SliderChangedEventHandler(this.OrbwalkToggle_sliderValueChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(16, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Orbwalk ";
            // 
            // RageModeToggle
            // 
            this.RageModeToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.RageModeToggle.BorderColor = System.Drawing.Color.LightGray;
            this.RageModeToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RageModeToggle.ForeColor = System.Drawing.Color.White;
            this.RageModeToggle.IsOn = false;
            this.RageModeToggle.Location = new System.Drawing.Point(142, 187);
            this.RageModeToggle.Name = "RageModeToggle";
            this.RageModeToggle.OffColor = System.Drawing.Color.DarkGray;
            this.RageModeToggle.OffText = "";
            this.RageModeToggle.OnColor = System.Drawing.Color.Green;
            this.RageModeToggle.OnText = "";
            this.RageModeToggle.Size = new System.Drawing.Size(28, 16);
            this.RageModeToggle.TabIndex = 12;
            this.RageModeToggle.Text = "ceLearningToggle3";
            this.RageModeToggle.TextEnabled = true;
            this.RageModeToggle.sliderValueChanged += new CatHack.ToggleButton.CeLearningToggle.SliderChangedEventHandler(this.RageModeToggle_sliderValueChanged);
            // 
            // NormalModeToggle
            // 
            this.NormalModeToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.NormalModeToggle.BorderColor = System.Drawing.Color.LightGray;
            this.NormalModeToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NormalModeToggle.ForeColor = System.Drawing.Color.White;
            this.NormalModeToggle.IsOn = false;
            this.NormalModeToggle.Location = new System.Drawing.Point(142, 142);
            this.NormalModeToggle.Name = "NormalModeToggle";
            this.NormalModeToggle.OffColor = System.Drawing.Color.DarkGray;
            this.NormalModeToggle.OffText = "";
            this.NormalModeToggle.OnColor = System.Drawing.Color.Green;
            this.NormalModeToggle.OnText = "";
            this.NormalModeToggle.Size = new System.Drawing.Size(28, 16);
            this.NormalModeToggle.TabIndex = 11;
            this.NormalModeToggle.Text = "ceLearningToggle2";
            this.NormalModeToggle.TextEnabled = true;
            this.NormalModeToggle.sliderValueChanged += new CatHack.ToggleButton.CeLearningToggle.SliderChangedEventHandler(this.NormalModeToggle_sliderValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(15, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rage Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Normal Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kite Mode";
            // 
            // KiteModeToggle
            // 
            this.KiteModeToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.KiteModeToggle.BorderColor = System.Drawing.Color.LightGray;
            this.KiteModeToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KiteModeToggle.ForeColor = System.Drawing.Color.White;
            this.KiteModeToggle.IsOn = false;
            this.KiteModeToggle.Location = new System.Drawing.Point(142, 96);
            this.KiteModeToggle.Name = "KiteModeToggle";
            this.KiteModeToggle.OffColor = System.Drawing.Color.DarkGray;
            this.KiteModeToggle.OffText = "";
            this.KiteModeToggle.OnColor = System.Drawing.Color.Green;
            this.KiteModeToggle.OnText = "";
            this.KiteModeToggle.Size = new System.Drawing.Size(28, 16);
            this.KiteModeToggle.TabIndex = 7;
            this.KiteModeToggle.Text = "ceLearningToggle1";
            this.KiteModeToggle.TextEnabled = true;
            this.KiteModeToggle.sliderValueChanged += new CatHack.ToggleButton.CeLearningToggle.SliderChangedEventHandler(this.KiteModeToggle_sliderValueChanged);
            // 
            // exitPicBox
            // 
            this.exitPicBox.BackColor = System.Drawing.Color.Transparent;
            this.exitPicBox.Image = global::CatHack.Properties.Resources.imageedit_1_6449737234;
            this.exitPicBox.Location = new System.Drawing.Point(16, 6);
            this.exitPicBox.Name = "exitPicBox";
            this.exitPicBox.Size = new System.Drawing.Size(40, 37);
            this.exitPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPicBox.TabIndex = 6;
            this.exitPicBox.TabStop = false;
            this.exitPicBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exitPicBox_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CatHack.Properties.Resources.imageedit_2_7235112875;
            this.pictureBox2.Location = new System.Drawing.Point(168, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CatHack.Properties.Resources.imageedit_2_7235112875;
            this.pictureBox3.Location = new System.Drawing.Point(168, 129);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CatHack.Properties.Resources.imageedit_2_7235112875;
            this.pictureBox4.Location = new System.Drawing.Point(168, 175);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(62, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CatHack.Properties.Resources.imageedit_2_7235112875;
            this.pictureBox5.Location = new System.Drawing.Point(168, 40);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(62, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // CatHackGUIOrb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(568, 238);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CatHackGUIOrb";
            this.Text = "CatHackGUI";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exitPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox exitPicBox;
        private ToggleButton.CeLearningToggle KiteModeToggle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ToggleButton.CeLearningToggle RageModeToggle;
        private ToggleButton.CeLearningToggle NormalModeToggle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private ToggleButton.CeLearningToggle OrbwalkToggle;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}