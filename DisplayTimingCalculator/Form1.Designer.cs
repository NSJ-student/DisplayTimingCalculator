namespace DisplayTimingCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHtotal = new TextBox();
            rtbScript = new RichTextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtHactive = new TextBox();
            txtHsync = new TextBox();
            txtHbp = new TextBox();
            txtVtotal = new TextBox();
            txtVactive = new TextBox();
            txtVsync = new TextBox();
            txtVbp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnConvert = new Button();
            txtPclk = new TextBox();
            label9 = new Label();
            rbRefPclk = new RadioButton();
            txtFps = new TextBox();
            label10 = new Label();
            rbRefFps = new RadioButton();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            label11 = new Label();
            txtMultiply = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtHtotal
            // 
            txtHtotal.Location = new Point(103, 17);
            txtHtotal.Name = "txtHtotal";
            txtHtotal.Size = new Size(125, 27);
            txtHtotal.TabIndex = 0;
            // 
            // rtbScript
            // 
            rtbScript.Dock = DockStyle.Fill;
            rtbScript.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtbScript.Location = new Point(0, 0);
            rtbScript.Name = "rtbScript";
            rtbScript.ReadOnly = true;
            rtbScript.Size = new Size(612, 492);
            rtbScript.TabIndex = 14;
            rtbScript.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 173);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 1;
            label5.Text = "V Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 206);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 1;
            label6.Text = "V Active";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 239);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 1;
            label7.Text = "Vsync";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 272);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 1;
            label8.Text = "Vbp";
            // 
            // txtHactive
            // 
            txtHactive.Location = new Point(103, 50);
            txtHactive.Name = "txtHactive";
            txtHactive.Size = new Size(125, 27);
            txtHactive.TabIndex = 1;
            // 
            // txtHsync
            // 
            txtHsync.Location = new Point(103, 83);
            txtHsync.Name = "txtHsync";
            txtHsync.Size = new Size(125, 27);
            txtHsync.TabIndex = 2;
            // 
            // txtHbp
            // 
            txtHbp.Location = new Point(103, 116);
            txtHbp.Name = "txtHbp";
            txtHbp.Size = new Size(125, 27);
            txtHbp.TabIndex = 3;
            // 
            // txtVtotal
            // 
            txtVtotal.Location = new Point(102, 170);
            txtVtotal.Name = "txtVtotal";
            txtVtotal.Size = new Size(125, 27);
            txtVtotal.TabIndex = 4;
            // 
            // txtVactive
            // 
            txtVactive.Location = new Point(102, 203);
            txtVactive.Name = "txtVactive";
            txtVactive.Size = new Size(125, 27);
            txtVactive.TabIndex = 5;
            // 
            // txtVsync
            // 
            txtVsync.Location = new Point(102, 236);
            txtVsync.Name = "txtVsync";
            txtVsync.Size = new Size(125, 27);
            txtVsync.TabIndex = 6;
            // 
            // txtVbp
            // 
            txtVbp.Location = new Point(102, 269);
            txtVbp.Name = "txtVbp";
            txtVbp.Size = new Size(125, 27);
            txtVbp.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "H Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 53);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "H Active";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 86);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Hsync";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 119);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 1;
            label4.Text = "Hbp";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(244, 143);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(112, 27);
            btnConvert.TabIndex = 13;
            btnConvert.Text = "Convert >>";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtPclk
            // 
            txtPclk.Location = new Point(102, 325);
            txtPclk.Name = "txtPclk";
            txtPclk.Size = new Size(125, 27);
            txtPclk.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 328);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 1;
            label9.Text = "PCLK";
            // 
            // rbRefPclk
            // 
            rbRefPclk.AutoSize = true;
            rbRefPclk.Checked = true;
            rbRefPclk.Location = new Point(244, 326);
            rbRefPclk.Name = "rbRefPclk";
            rbRefPclk.Size = new Size(88, 24);
            rbRefPclk.TabIndex = 11;
            rbRefPclk.TabStop = true;
            rbRefPclk.Text = "ref PCLK";
            rbRefPclk.UseVisualStyleBackColor = true;
            rbRefPclk.CheckedChanged += rbRefPclk_CheckedChanged;
            // 
            // txtFps
            // 
            txtFps.Enabled = false;
            txtFps.Location = new Point(102, 361);
            txtFps.Name = "txtFps";
            txtFps.Size = new Size(125, 27);
            txtFps.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 364);
            label10.Name = "label10";
            label10.Size = new Size(33, 20);
            label10.TabIndex = 1;
            label10.Text = "FPS";
            // 
            // rbRefFps
            // 
            rbRefFps.AutoSize = true;
            rbRefFps.Location = new Point(244, 362);
            rbRefFps.Name = "rbRefFps";
            rbRefFps.Size = new Size(75, 24);
            rbRefFps.TabIndex = 12;
            rbRefFps.Text = "ref Fps";
            rbRefFps.UseVisualStyleBackColor = true;
            rbRefFps.CheckedChanged += rbRefFps_CheckedChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(rtbScript);
            splitContainer1.Size = new Size(1036, 492);
            splitContainer1.SplitterDistance = 420;
            splitContainer1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rbRefFps);
            panel1.Controls.Add(txtHtotal);
            panel1.Controls.Add(rbRefPclk);
            panel1.Controls.Add(txtHactive);
            panel1.Controls.Add(btnConvert);
            panel1.Controls.Add(txtHsync);
            panel1.Controls.Add(txtHbp);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtVtotal);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtVactive);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtVsync);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtMultiply);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtVbp);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtPclk);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFps);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 492);
            panel1.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 417);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 1;
            label11.Text = "Multiply";
            // 
            // txtMultiply
            // 
            txtMultiply.Location = new Point(102, 414);
            txtMultiply.Name = "txtMultiply";
            txtMultiply.Size = new Size(125, 27);
            txtMultiply.TabIndex = 10;
            txtMultiply.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 492);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Display Timing Script Generator";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtHtotal;
        private RichTextBox rtbScript;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtHactive;
        private TextBox txtHsync;
        private TextBox txtHbp;
        private TextBox txtVtotal;
        private TextBox txtVactive;
        private TextBox txtVsync;
        private TextBox txtVbp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConvert;
        private TextBox txtPclk;
        private Label label9;
        private RadioButton rbRefPclk;
        private TextBox txtFps;
        private Label label10;
        private RadioButton rbRefFps;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label11;
        private TextBox txtMultiply;
    }
}