using DarkUI.Controls;
using System;



namespace WindowsFormsApp2


{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.darkCheckBox1 = new DarkUI.Controls.DarkCheckBox();
            this.rgbTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minimizeB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.darkComboBox1 = new DarkUI.Controls.DarkComboBox();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.darkGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.darkGroupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(149, 41);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(118, 45);
            this.darkButton1.TabIndex = 7;
            this.darkButton1.Text = "Inject";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "impleLoader";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(855, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // darkCheckBox1
            // 
            this.darkCheckBox1.AutoSize = true;
            this.darkCheckBox1.Checked = true;
            this.darkCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkCheckBox1.Location = new System.Drawing.Point(20, 18);
            this.darkCheckBox1.Name = "darkCheckBox1";
            this.darkCheckBox1.Size = new System.Drawing.Size(102, 17);
            this.darkCheckBox1.TabIndex = 13;
            this.darkCheckBox1.Text = "Rainbow Border";
            this.darkCheckBox1.CheckedChanged += new System.EventHandler(this.darkCheckBox1_CheckedChanged);
            // 
            // rgbTimer
            // 
            this.rgbTimer.Enabled = true;
            this.rgbTimer.Interval = 5;
            this.rgbTimer.Tick += new System.EventHandler(this.rgbTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 300);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel3.Controls.Add(this.minimizeB);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.exitB);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 47);
            this.panel3.TabIndex = 16;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // minimizeB
            // 
            this.minimizeB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.minimizeB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeB.FlatAppearance.BorderSize = 0;
            this.minimizeB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.minimizeB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.minimizeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeB.ForeColor = System.Drawing.Color.White;
            this.minimizeB.Location = new System.Drawing.Point(331, 2);
            this.minimizeB.Name = "minimizeB";
            this.minimizeB.Size = new System.Drawing.Size(35, 35);
            this.minimizeB.TabIndex = 18;
            this.minimizeB.Text = "_";
            this.minimizeB.UseVisualStyleBackColor = false;
            this.minimizeB.Click += new System.EventHandler(this.minimizeB_Click);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.exitB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitB.FlatAppearance.BorderSize = 0;
            this.exitB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitB.ForeColor = System.Drawing.Color.White;
            this.exitB.Location = new System.Drawing.Point(366, 2);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(35, 35);
            this.exitB.TabIndex = 17;
            this.exitB.Text = "X";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 35);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.darkGroupBox1);
            this.panel2.Location = new System.Drawing.Point(4, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 221);
            this.panel2.TabIndex = 15;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // darkGroupBox2
            // 
            this.darkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox2.Controls.Add(this.label8);
            this.darkGroupBox2.Controls.Add(this.label7);
            this.darkGroupBox2.Controls.Add(this.label4);
            this.darkGroupBox2.Controls.Add(this.label3);
            this.darkGroupBox2.Controls.Add(this.label6);
            this.darkGroupBox2.Controls.Add(this.pictureBox1);
            this.darkGroupBox2.Controls.Add(this.pictureBox2);
            this.darkGroupBox2.Controls.Add(this.label5);
            this.darkGroupBox2.Location = new System.Drawing.Point(-2, 1);
            this.darkGroupBox2.Name = "darkGroupBox2";
            this.darkGroupBox2.Size = new System.Drawing.Size(407, 132);
            this.darkGroupBox2.TabIndex = 15;
            this.darkGroupBox2.TabStop = false;
            this.darkGroupBox2.Text = "Credits";
            this.darkGroupBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label8.Location = new System.Drawing.Point(294, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "#4079";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label7.Location = new System.Drawing.Point(124, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "#8549";
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Main developer, made the base\r\nand most of the loader\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(60, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "elondogg";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label6.Location = new System.Drawing.Point(209, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 42);
            this.label6.TabIndex = 13;
            this.label6.Text = "Helped with issues and features.\r\nAlso made the GUI && cfg sys\r\n\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(64, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(270, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 54);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.label5.Location = new System.Drawing.Point(266, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "enit";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.darkGroupBox1.Controls.Add(this.panel5);
            this.darkGroupBox1.Controls.Add(this.darkButton3);
            this.darkGroupBox1.Controls.Add(this.darkComboBox1);
            this.darkGroupBox1.Controls.Add(this.darkButton2);
            this.darkGroupBox1.Controls.Add(this.darkCheckBox1);
            this.darkGroupBox1.Controls.Add(this.darkButton1);
            this.darkGroupBox1.Location = new System.Drawing.Point(0, 1);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(403, 220);
            this.darkGroupBox1.TabIndex = 14;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "General";
            this.darkGroupBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            this.darkGroupBox1.Enter += new System.EventHandler(this.darkGroupBox1_Enter);
            // 
            // darkComboBox1
            // 
            this.darkComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.darkComboBox1.FormattingEnabled = true;
            this.darkComboBox1.Items.AddRange(new object[] {
            "Fluidaim",
            "Seaside",
            "OTCv3"});
            this.darkComboBox1.Location = new System.Drawing.Point(20, 41);
            this.darkComboBox1.Name = "darkComboBox1";
            this.darkComboBox1.Size = new System.Drawing.Size(118, 21);
            this.darkComboBox1.TabIndex = 16;
            this.darkComboBox1.SelectedIndexChanged += new System.EventHandler(this.darkComboBox1_SelectedIndexChanged);
            // 
            // darkButton2
            // 
            this.darkButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("darkButton2.BackgroundImage")));
            this.darkButton2.Location = new System.Drawing.Point(277, 41);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(118, 45);
            this.darkButton2.TabIndex = 14;
            this.darkButton2.Text = "Save Config";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(4, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 5);
            this.panel4.TabIndex = 15;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMove);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.darkGroupBox2);
            this.panel5.Location = new System.Drawing.Point(0, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(403, 132);
            this.panel5.TabIndex = 16;
            // 
            // darkButton3
            // 
            this.darkButton3.Location = new System.Drawing.Point(20, 64);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(118, 22);
            this.darkButton3.TabIndex = 15;
            this.darkButton3.Text = "Credits";
            this.darkButton3.Click += new System.EventHandler(this.darkButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(411, 276);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SimpleLoader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.darkGroupBox2.ResumeLayout(false);
            this.darkGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkButton darkButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DarkUI.Controls.DarkCheckBox darkCheckBox1;
        private System.Windows.Forms.Timer rgbTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DarkUI.Controls.DarkGroupBox darkGroupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button minimizeB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkComboBox darkComboBox1;
        private System.Windows.Forms.Panel panel5;
        private DarkButton darkButton3;
    }
}

