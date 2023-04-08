using System.Drawing;
using System.Windows.Forms;

namespace DisplayTimingCalculator_.Net4._8
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHtotal = new System.Windows.Forms.TextBox();
            this.rtbScript = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHactive = new System.Windows.Forms.TextBox();
            this.txtHsync = new System.Windows.Forms.TextBox();
            this.txtHbp = new System.Windows.Forms.TextBox();
            this.txtVtotal = new System.Windows.Forms.TextBox();
            this.txtVactive = new System.Windows.Forms.TextBox();
            this.txtVsync = new System.Windows.Forms.TextBox();
            this.txtVbp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtPclk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbRefPclk = new System.Windows.Forms.RadioButton();
            this.txtFps = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbRefFps = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMultiply = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHtotal
            // 
            this.txtHtotal.Location = new System.Drawing.Point(80, 10);
            this.txtHtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtHtotal.Name = "txtHtotal";
            this.txtHtotal.Size = new System.Drawing.Size(98, 21);
            this.txtHtotal.TabIndex = 0;
            this.txtHtotal.Text = "1650";
            // 
            // rtbScript
            // 
            this.rtbScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbScript.Font = new System.Drawing.Font("Courier New", 9F);
            this.rtbScript.Location = new System.Drawing.Point(0, 0);
            this.rtbScript.Margin = new System.Windows.Forms.Padding(2);
            this.rtbScript.Name = "rtbScript";
            this.rtbScript.ReadOnly = true;
            this.rtbScript.Size = new System.Drawing.Size(594, 400);
            this.rtbScript.TabIndex = 14;
            this.rtbScript.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "V Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "V Active";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Vsync";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 163);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Vbp";
            // 
            // txtHactive
            // 
            this.txtHactive.Location = new System.Drawing.Point(80, 30);
            this.txtHactive.Margin = new System.Windows.Forms.Padding(2);
            this.txtHactive.Name = "txtHactive";
            this.txtHactive.Size = new System.Drawing.Size(98, 21);
            this.txtHactive.TabIndex = 1;
            this.txtHactive.Text = "1280";
            // 
            // txtHsync
            // 
            this.txtHsync.Location = new System.Drawing.Point(80, 50);
            this.txtHsync.Margin = new System.Windows.Forms.Padding(2);
            this.txtHsync.Name = "txtHsync";
            this.txtHsync.Size = new System.Drawing.Size(98, 21);
            this.txtHsync.TabIndex = 2;
            this.txtHsync.Text = "56";
            // 
            // txtHbp
            // 
            this.txtHbp.Location = new System.Drawing.Point(80, 70);
            this.txtHbp.Margin = new System.Windows.Forms.Padding(2);
            this.txtHbp.Name = "txtHbp";
            this.txtHbp.Size = new System.Drawing.Size(98, 21);
            this.txtHbp.TabIndex = 3;
            this.txtHbp.Text = "274";
            // 
            // txtVtotal
            // 
            this.txtVtotal.Location = new System.Drawing.Point(79, 102);
            this.txtVtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtVtotal.Name = "txtVtotal";
            this.txtVtotal.Size = new System.Drawing.Size(98, 21);
            this.txtVtotal.TabIndex = 4;
            this.txtVtotal.Text = "750";
            // 
            // txtVactive
            // 
            this.txtVactive.Location = new System.Drawing.Point(79, 122);
            this.txtVactive.Margin = new System.Windows.Forms.Padding(2);
            this.txtVactive.Name = "txtVactive";
            this.txtVactive.Size = new System.Drawing.Size(98, 21);
            this.txtVactive.TabIndex = 5;
            this.txtVactive.Text = "720";
            // 
            // txtVsync
            // 
            this.txtVsync.Location = new System.Drawing.Point(79, 142);
            this.txtVsync.Margin = new System.Windows.Forms.Padding(2);
            this.txtVsync.Name = "txtVsync";
            this.txtVsync.Size = new System.Drawing.Size(98, 21);
            this.txtVsync.TabIndex = 6;
            this.txtVsync.Text = "6";
            // 
            // txtVbp
            // 
            this.txtVbp.Location = new System.Drawing.Point(79, 161);
            this.txtVbp.Margin = new System.Windows.Forms.Padding(2);
            this.txtVbp.Name = "txtVbp";
            this.txtVbp.Size = new System.Drawing.Size(98, 21);
            this.txtVbp.TabIndex = 7;
            this.txtVbp.Text = "22";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "H Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "H Active";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hsync";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hbp";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(190, 86);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(2);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(87, 30);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = "Convert >>";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtPclk
            // 
            this.txtPclk.Location = new System.Drawing.Point(79, 195);
            this.txtPclk.Margin = new System.Windows.Forms.Padding(2);
            this.txtPclk.Name = "txtPclk";
            this.txtPclk.Size = new System.Drawing.Size(98, 21);
            this.txtPclk.TabIndex = 8;
            this.txtPclk.Text = "37130625";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 197);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "PCLK";
            // 
            // rbRefPclk
            // 
            this.rbRefPclk.AutoSize = true;
            this.rbRefPclk.Checked = true;
            this.rbRefPclk.Location = new System.Drawing.Point(190, 196);
            this.rbRefPclk.Margin = new System.Windows.Forms.Padding(2);
            this.rbRefPclk.Name = "rbRefPclk";
            this.rbRefPclk.Size = new System.Drawing.Size(73, 16);
            this.rbRefPclk.TabIndex = 11;
            this.rbRefPclk.TabStop = true;
            this.rbRefPclk.Text = "ref PCLK";
            this.rbRefPclk.UseVisualStyleBackColor = true;
            // 
            // txtFps
            // 
            this.txtFps.Enabled = false;
            this.txtFps.Location = new System.Drawing.Point(79, 217);
            this.txtFps.Margin = new System.Windows.Forms.Padding(2);
            this.txtFps.Name = "txtFps";
            this.txtFps.Size = new System.Drawing.Size(98, 21);
            this.txtFps.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "FPS";
            // 
            // rbRefFps
            // 
            this.rbRefFps.AutoSize = true;
            this.rbRefFps.Location = new System.Drawing.Point(190, 217);
            this.rbRefFps.Margin = new System.Windows.Forms.Padding(2);
            this.rbRefFps.Name = "rbRefFps";
            this.rbRefFps.Size = new System.Drawing.Size(62, 16);
            this.rbRefFps.TabIndex = 12;
            this.rbRefFps.Text = "ref Fps";
            this.rbRefFps.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbScript);
            this.splitContainer1.Size = new System.Drawing.Size(898, 400);
            this.splitContainer1.SplitterDistance = 301;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbRefFps);
            this.panel1.Controls.Add(this.txtHtotal);
            this.panel1.Controls.Add(this.rbRefPclk);
            this.panel1.Controls.Add(this.txtHactive);
            this.panel1.Controls.Add(this.btnConvert);
            this.panel1.Controls.Add(this.txtHsync);
            this.panel1.Controls.Add(this.txtHbp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtVtotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtVactive);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtVsync);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtMultiply);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtVbp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPclk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFps);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 400);
            this.panel1.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 250);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "Multiply";
            // 
            // txtMultiply
            // 
            this.txtMultiply.Location = new System.Drawing.Point(79, 248);
            this.txtMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.txtMultiply.Name = "txtMultiply";
            this.txtMultiply.Size = new System.Drawing.Size(98, 21);
            this.txtMultiply.TabIndex = 10;
            this.txtMultiply.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 400);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Display Timing Script Generator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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

