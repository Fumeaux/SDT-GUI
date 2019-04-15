using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondaryDesignTool
{
    public partial class SDT_GUI : Form
    {
        public SDT_GUI()
        {
            InitializeComponent();
        }

        private void btnApprox_Click(object sender, EventArgs e)
        {
            try
            {
                List<Coil> coils = new List<Coil>();
                Coil coil;
                for(double wd = 0.1; wd < 1.5; wd += 0.01)
                {
                    coil = new Coil(int.Parse(txtAppoxCoilDiameter.Text), int.Parse(txtAppoxCoilDiameter.Text) * (double.Parse(txtLoAccRa.Text) + double.Parse(txtUpAccRa.Text)) / 2, wd);
                    coil.UpAccIm = double.Parse(txtUpAccIm.Text);
                    coil.LoAccIm = double.Parse(txtLoAccIm.Text);
                    coil.UpAccRa = double.Parse(txtUpAccRa.Text);
                    coil.LoAccRa = double.Parse(txtLoAccRa.Text);
                    coil.ToLoFa = double.Parse(txtToLoFa.Text);
                    if (coil.isImpedanceSafe)
                        coils.Add(coil);
                }
                txtApproxOutput.Text = coils.First().WireDiameter.ToString() + " - " + coils.Last().WireDiameter.ToString();
                if (coils.Count == 0)
                {
                    txtApproxOutput.Text = "oops";
                }

            }
            catch
            {
                txtApproxOutput.Text = "";
            }
        }

        List<Coil> outputCoils;

        private void btnGlobalCalc_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = "";
                double wirediameter = double.Parse(txtGlobalWireDiameter.Text);
                double coilDiameter = double.Parse(txtGlobalCoilDiameter.Text);
                double filterFrequency = double.MaxValue;
                if(txtFilterFrequency.TextLength != 0)
                    double.TryParse(txtFilterFrequency.Text, out filterFrequency);
                List<Coil> coils = new List<Coil>();
                Coil tmpCoil;
                for (double coilHeight = coilDiameter * 7; coilHeight > 0; coilHeight -= coilDiameter/13)
                {
                    tmpCoil = new Coil(coilDiameter, coilHeight, wirediameter);
                    tmpCoil.UpAccIm = double.Parse(txtUpAccIm.Text);
                    tmpCoil.LoAccIm = double.Parse(txtLoAccIm.Text);
                    tmpCoil.UpAccRa = double.Parse(txtUpAccRa.Text);
                    tmpCoil.LoAccRa = double.Parse(txtLoAccRa.Text);
                    tmpCoil.ToLoFa = double.Parse(txtToLoFa.Text);
                    if (tmpCoil.isDoubleSafe && tmpCoil.Frequency <= filterFrequency)
                        coils.Add(tmpCoil);
                }
                outputCoils = coils;
                btnGlobalCalc.BackColor = Color.Green;
                txtCount.Text = outputCoils.Count.ToString() + " Coil(s)";
                if (outputCoils.Count == 0)
                {
                    btnGlobalCalc.BackColor = Color.Yellow;
                    txtCount.Text = outputCoils.Count.ToString() + " Coil(s)";
                }
                for (int i = 0; i < outputCoils.Count; i++)
                {
                    richTextBox1.AppendText(outputCoils.ToArray<Coil>()[i].ToString() + Environment.NewLine);
                }
            }
            catch
            {
                btnGlobalCalc.BackColor = Color.Red;
                txtCount.Text = "You did something wrong";
                outputCoils = null;
            }
        }

        private void btnGlobalExport_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(var coil in outputCoils)
                {
                    var filePath = @txtOutputFilePath.Text;
                    File.Copy(@"empty.java", filePath + "/" + coil.CoilLength.ToString("#.#") + "mm X " + coil.CoilDiameter.ToString() + "mm_" + coil.WireDiameter.ToString() + "mm.java");
                    string[] file = File.ReadAllLines(filePath + "/" + coil.CoilLength.ToString("#.#") + "mm X " + coil.CoilDiameter.ToString() + "mm_" + coil.WireDiameter.ToString() + "mm.java");

                    file[11] = "s_radius1=" + (coil.CoilDiameter / 20).ToString().Replace(',', '.') + ",";
                    file[12] = "s_radius2=" + (coil.CoilDiameter / 20).ToString().Replace(',', '.') + ",";
                    file[13] = "s_height1=0,";
                    file[14] = "s_height2=" + (coil.CoilLength / 10).ToString().Replace(',', '.') + ",";
                    file[15] = "s_turn=" + (coil.Turns - 1).ToString().Replace(',', '.') + ",";
                    file[16] = "s_wd=" + (coil.WireDiameter / 10).ToString().Replace(',', '.') + ",";

                    file[38] = "t.inner=" + (coil.ToroidMinorDiameter / 10).ToString().Replace(',', '.') + ",";
                    file[39] = "t.outer=" + (coil.ToroidMajorDiameter / 10).ToString().Replace(',', '.') + ",";
                    file[40] = "t.height=" + ((coil.CoilLength + coil.ToroidMinorDiameter / 2) / 10).ToString().Replace(',', '.') + ",";

                    File.WriteAllLines(filePath + "/" + coil.CoilLength.ToString("#.#") + "mm X " + coil.CoilDiameter.ToString() + "mm_" + coil.WireDiameter.ToString() + "mm.java", file);
                }
            }
            catch
            {
                MessageBox.Show("Something I don't know went wrong", "Warning");
            }
        }

        private void btnJavaTC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.classictesla.com/java/javatc3d/javatc3d.html");
        }

        private bool expanded = false;

        private void txtToggleSettings_Click(object sender, EventArgs e)
        {
            if (expanded)
            {
                expanded = false;
                txtFilterFrequency.Visible = false;
                txtUpAccIm.Visible = false;
                txtLoAccIm.Visible = false;
                txtUpAccRa.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                txtToLoFa.Visible = false;
                txtLoAccRa.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
            }
            else
            {
                expanded = true;
                txtFilterFrequency.Visible = true;
                txtUpAccIm.Visible = true;
                txtLoAccIm.Visible = true;
                txtUpAccRa.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                txtToLoFa.Visible = true;
                txtLoAccRa.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label15.Visible = true;
            }
        }

        private void txtUpAccRa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtApproxRatio.Text = ((double.Parse(txtLoAccRa.Text) + double.Parse(txtUpAccRa.Text)) / 2).ToString("#.##");

            }
            catch
            {

            }
        }

        private void txtLoAccRa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtApproxRatio.Text = ((double.Parse(txtLoAccRa.Text) + double.Parse(txtUpAccRa.Text)) / 2).ToString("#.##");

            }
            catch
            {

            }
        }

        private void trkAppoxCoilDiameter_Scroll(object sender, EventArgs e)
        {
            txtAppoxCoilDiameter.Text = (40 + trkAppoxCoilDiameter.Value * 10).ToString();
            txtGlobalCoilDiameter.Text = (40 + trkAppoxCoilDiameter.Value * 10).ToString();
        }
    }
}
