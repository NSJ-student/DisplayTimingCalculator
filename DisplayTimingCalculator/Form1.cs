namespace DisplayTimingCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool checkCalculateAvailable()
        {
            if (txtMultiply.Text == "")
            {
                return false;
            }

            if (txtHactive.Text == "")
            {
                return false;
            }

            if (txtHbp.Text == "")
            {
                return false;
            }

            if (txtHsync.Text == "")
            {
                return false;
            }

            if (txtHtotal.Text == "")
            {
                return false;
            }

            if (txtVactive.Text == "")
            {
                return false;
            }

            if (txtVbp.Text == "")
            {
                return false;
            }

            if (txtVsync.Text == "")
            {
                return false;
            }

            if (txtVtotal.Text == "")
            {
                return false;
            }

            if (rbRefFps.Checked)
            {
                if (txtFps.Text == "")
                {
                    return false;
                }
            }
            if (rbRefPclk.Checked)
            {
                if (txtPclk.Text == "")
                {
                    return false;
                }
            }

            return true;
        }

        private void rbRefPclk_CheckedChanged(object sender, EventArgs e)
        {
            txtPclk.Enabled = true;
            txtFps.Enabled = false;
        }

        private void rbRefFps_CheckedChanged(object sender, EventArgs e)
        {
            txtPclk.Enabled = false;
            txtFps.Enabled = true;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!checkCalculateAvailable())
            {
                return;
            }

            double multiply = Convert.ToDouble(txtMultiply.Text);
            if (multiply == 0) { return; }

            int htotal = Convert.ToInt32(txtHtotal.Text);
            if (htotal == 0) { return; }
            int hactive = Convert.ToInt32(txtHactive.Text);
            if (hactive == 0) { return; }
            int hbp = Convert.ToInt32(txtHbp.Text);
            if (hbp == 0) { return; }
            int hsync = Convert.ToInt32(txtHsync.Text);
            if (hsync == 0) { return; }
            int vactive = Convert.ToInt32(txtVactive.Text);
            if (vactive == 0) { return; }
            int vbp = Convert.ToInt32(txtVbp.Text);
            if (vbp == 0) { return; }
            int vsync = Convert.ToInt32(txtVsync.Text);
            if (vsync == 0) { return; }
            int vtotal = Convert.ToInt32(txtVtotal.Text);
            if (vtotal == 0) { return; }
            int pclk = 0;
            int fps = 0;


            if (rbRefFps.Checked)
            {
                fps = Convert.ToInt32(txtFps.Text);
                if (fps == 0) { return; }
                pclk = (int)(htotal * vtotal * fps * multiply);
                txtPclk.Text = pclk.ToString();
            }
            if (rbRefPclk.Checked)
            {
                pclk = Convert.ToInt32(txtPclk.Text);
                if (pclk == 0) { return; }
                fps = pclk / (htotal * vtotal);
                txtFps.Text = fps.ToString();
            }

            htotal = (int)(Convert.ToInt32(txtHtotal.Text) * multiply);
            hactive = (int)(Convert.ToInt32(txtHactive.Text) * multiply);
            hbp = (int)(Convert.ToInt32(txtHbp.Text) * multiply);
            hsync = (int)(Convert.ToInt32(txtHsync.Text) * multiply);
            vactive = (int)(Convert.ToInt32(txtVactive.Text) * multiply);
            vbp = (int)(Convert.ToInt32(txtVbp.Text) * multiply);
            vsync = (int)(Convert.ToInt32(txtVsync.Text) * multiply);
            vtotal = (int)(Convert.ToInt32(txtVtotal.Text) * multiply);

            rtbScript.Clear();

            int vs_high = vsync * htotal;
            int vs_low = (vtotal - vsync) * htotal;
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01ce {0:X2}  # VS high (DSB)\n", (vs_high >> 8) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01cf {0:X2}  # VS high (LSB) {1}\n", (vs_high >> 0) & 0xFF, vs_high));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01d0 {0:X2}  # VS low (MSB)\n", (vs_low >> 16) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01d1 {0:X2}  # VS low (DSB)\n", (vs_low >> 8) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01d2 {0:X2}  # VS low (LSB) {1}\n", (vs_low >> 0) & 0xFF, vs_low));

            int hs_high = hsync;
            int hs_low = htotal - hsync;
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01d6 {0:X2}  # HS high (MSB)\n", (hs_high >> 8) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01d7 {0:X2}  # HS high (LSB) {1}\n", (hs_high >> 0) & 0xFF, hs_high));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01d8 {0:X2}  # HS low  (MSB)\n", (hs_low >> 8) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01d9 {0:X2}  # HS low  (LSB) {1}\n", (hs_low >> 0) & 0xFF, hs_low));

            int hs_pulses_per_frame = vtotal;
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01da {0:X2}  # HS pulses per frame (MSB)\n",
                                                (hs_pulses_per_frame >> 8) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01db {0:X2}  # HS pulses per frame (LSB) {1}\n",
                                                (hs_pulses_per_frame >> 0) & 0xFF, hs_pulses_per_frame));

            int vs_edge_to_rising_edge_of_first_de = (vsync + vbp) * htotal + hsync + hbp;
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01dc {0:X2}  # VS edge to the rising edge of the first DE (MSB)\n",
                                                (vs_edge_to_rising_edge_of_first_de >> 16) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01dd {0:X2}  # VS edge to the rising edge of the first DE (DSB)\n",
                                                (vs_edge_to_rising_edge_of_first_de >> 8) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01de {0:X2}  # VS edge to the rising edge of the first DE (LSB) {1}\n",
                                                (vs_edge_to_rising_edge_of_first_de >> 0) & 0xFF, vs_edge_to_rising_edge_of_first_de));

            int de_high = hactive;
            int de_low = htotal - hactive;
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01df {0:X2}  # DE high (MSB)\n", (de_high >> 8) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01e0 {0:X2}  # DE high (LSB) {1}\n", (de_high >> 0) & 0xFF, de_high));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01e1 {0:X2}  # DE low  (MSB)\n", (de_low >> 8) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01e2 {0:X2}  # DE low  (LSB) {1}\n", (de_low >> 0) & 0xFF, de_low));

            int active_lines_per_frame = vactive;
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01d3 {0:X2}  # Active lines per frame (MSB)\n",
                                                (active_lines_per_frame >> 8) & 0xFF));
            rtbScript.AppendText(String.Format("rem_ww2 2 40 01d4 {0:X2}  # Active lines per frame (LSB) {1}\n",
                                                (active_lines_per_frame >> 0) & 0xFF, active_lines_per_frame));
        }
    }
}