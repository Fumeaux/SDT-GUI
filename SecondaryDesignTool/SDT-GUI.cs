using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            ParseAll();
            try
            {
                double ToploadCapacity = 0;
                double.TryParse(txtToploadCap.Text, out ToploadCapacity);
                List<Coil> coils = new List<Coil>();
                Coil coil;
                for(double wd = 0.01; wd < 1.5; wd += 0.01)
                {
                    coil = new Coil(double.Parse(txtAppoxCoilDiameter.Text), double.Parse(txtAppoxCoilDiameter.Text) * (double.Parse(txtLoAccRa.Text) + double.Parse(txtUpAccRa.Text)) / 2, wd, double.Parse(txtEnamThick.Text))
                    {
                        UpAccIm = double.Parse(txtUpAccIm.Text),
                        LoAccIm = double.Parse(txtLoAccIm.Text),
                        UpAccRa = double.Parse(txtUpAccRa.Text),
                        LoAccRa = double.Parse(txtLoAccRa.Text),
                        ToLoFa = double.Parse(txtToLoFa.Text),
                        ToroidCapacity = ToploadCapacity
                    };
                    if (coil.isImpedanceSafe)
                        coils.Add(coil);
                }
                txtApproxOutput.Text = coils.First().WireDiameter.ToString("#.###") + " - " + coils.Last().WireDiameter.ToString("#.###");
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
            ParseAll();
            try
            {
                richTextBox1.Items.Clear();
                double wirediameter = double.Parse(txtGlobalWireDiameter.Text);
                double coilDiameter = double.Parse(txtGlobalCoilDiameter.Text);
                double filterFrequency = double.MaxValue;
                if(txtFilterFrequency.TextLength != 0)
                    double.TryParse(txtFilterFrequency.Text, out filterFrequency);
                double ToploadCapacity = 0;
                double.TryParse(txtToploadCap.Text, out ToploadCapacity);
                List<Coil> coils = new List<Coil>();
                Coil tmpCoil;
                for (double coilHeight = coilDiameter * 7; coilHeight > 0; coilHeight -= coilDiameter/14)
                {
                    tmpCoil = new Coil(coilDiameter, coilHeight, wirediameter, double.Parse(txtEnamThick.Text))
                    {
                        UpAccIm = double.Parse(txtUpAccIm.Text),
                        LoAccIm = double.Parse(txtLoAccIm.Text),
                        UpAccRa = double.Parse(txtUpAccRa.Text),
                        LoAccRa = double.Parse(txtLoAccRa.Text),
                        ToLoFa = double.Parse(txtToLoFa.Text),
                        ToroidCapacity = ToploadCapacity
                    };
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
                    richTextBox1.Items.Add(outputCoils.ElementAt(i));
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
            if (!File.Exists(@"empty.java"))
            {
                using (StreamWriter sw = new StreamWriter(@"empty.java", true))
                {
                    //sw.WriteLine("units=1,ambient = 1,s_ws = 1,s_Al = 0,p_ws = 1,p_Al = 0,p_ribbon = 0,temp = 20,g_radius = 0,w_radius = 0,ceil_height = 0,s_radius1 = 0,s_radius2 = 0,s_height1 = 0,s_height2 = 0,s_turn = 0,s_wd = 0,p_radius1 = 0,p_radius2 = 0,p_height1 = 0,p_height2 = 0,p_turn = 0,p_wd = 0,p_vwidth = 0,p_rthick = 0,Cp_uF = 0,Lead_Length = 0,Lead_Diameter = 0,desired_k = 0,r_inner = 0,r_outer = 0,ringgroupminor = 0,ringN = 0,StartAngle = 90,EndAngle = 270,r_height = 0,RT = true,RG = false,t.inner = 10,t.outer = 30,t.height = 50,TT = true,TG = false,x_Vin = 0,x_Vout = 0,x_Iout = 0,x_Hz = 0,x_Vadjust = 0,x_ballast = 0,rsg_ELS = 0,rsg_ELR = 0,rsg_rpm = 0,rsg_disc_D = 0,rsg_ELR_D = 0,rsg_ELS_D = 0,stat_EL = 0,stat_EL_D = 0,stat_gap = 0,SPE = true,RGE = false");

                    sw.WriteLine("units = 1,");
                    sw.WriteLine("ambient = 1,");
                    sw.WriteLine("s_ws = 1,");
                    sw.WriteLine("s_Al = 0,");
                    sw.WriteLine("p_ws = 1,");
                    sw.WriteLine("p_Al = 0,");
                    sw.WriteLine("p_ribbon = 0,");
                    sw.WriteLine("temp = 20,");
                    sw.WriteLine("g_radius = 0,");
                    sw.WriteLine("w_radius = 0,");
                    sw.WriteLine("ceil_height = 0,");
                    sw.WriteLine("s_radius1 = 0,");
                    sw.WriteLine("s_radius2 = 0,");
                    sw.WriteLine("s_height1 = 0,");
                    sw.WriteLine("s_height2 = 0,");
                    sw.WriteLine("s_turn = 0,");
                    sw.WriteLine("s_wd = 0,");
                    sw.WriteLine("p_radius1 = 0,");
                    sw.WriteLine("p_radius2 = 0,");
                    sw.WriteLine("p_height1 = 0,");
                    sw.WriteLine("p_height2 = 0,");
                    sw.WriteLine("p_turn = 0,");
                    sw.WriteLine("p_wd = 0,");
                    sw.WriteLine("p_vwidth = 0,");
                    sw.WriteLine("p_rthick = 0,");
                    sw.WriteLine("Cp_uF = 0,");
                    sw.WriteLine("Lead_Length = 0,");
                    sw.WriteLine("Lead_Diameter = 0,");
                    sw.WriteLine("desired_k = 0,");
                    sw.WriteLine("r_inner = 0,");
                    sw.WriteLine("r_outer = 0,");
                    sw.WriteLine("ringgroupminor = 0,");
                    sw.WriteLine("ringN = 0,");
                    sw.WriteLine("StartAngle = 90,");
                    sw.WriteLine("EndAngle = 270,");
                    sw.WriteLine("r_height = 0,");
                    sw.WriteLine("RT = true,");
                    sw.WriteLine("RG = false,");
                    sw.WriteLine("t.inner = 10,");
                    sw.WriteLine("t.outer = 30,");
                    sw.WriteLine("t.height = 50,");
                    sw.WriteLine("TT = true,");
                    sw.WriteLine("TG = false,");
                    sw.WriteLine("x_Vin = 0,");
                    sw.WriteLine("x_Vout = 0,");
                    sw.WriteLine("x_Iout = 0,");
                    sw.WriteLine("x_Hz = 0,");
                    sw.WriteLine("x_Vadjust = 0,");
                    sw.WriteLine("x_ballast = 0,");
                    sw.WriteLine("rsg_ELS = 0,");
                    sw.WriteLine("rsg_ELR = 0,");
                    sw.WriteLine("rsg_rpm = 0,");
                    sw.WriteLine("rsg_disc_D = 0,");
                    sw.WriteLine("rsg_ELR_D = 0,");
                    sw.WriteLine("rsg_ELS_D = 0,");
                    sw.WriteLine("stat_EL = 0,");
                    sw.WriteLine("stat_EL_D = 0,");
                    sw.WriteLine("stat_gap = 0,");
                    sw.WriteLine("SPE = true,");
                    sw.WriteLine("RGE = false");
                }
            }
            try
            {
                foreach(Coil coil in richTextBox1.CheckedItems)
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
                if (txtOutputFilePath.TextLength != 0)
                    Process.Start("explorer.exe", txtOutputFilePath.Text);
                else
                {
                    var path = @"C:\Users\" + Environment.UserName + @"\Documents\SDT\";
                    Process.Start("explorer.exe", path);
                }
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
                txtToploadCap.Visible = false;
                txtEnamThick.Visible = false;
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
                txtToploadCap.Visible = true;
                txtEnamThick.Visible = true;
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
            txtUpAccRa.Select(txtUpAccRa.Text.Length, 0);
            updateAll();
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
            txtLoAccRa.Select(txtLoAccRa.Text.Length, 0);
            updateAll();
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
            updateAll();
            switch (trkAppoxCoilDiameter.Value)
            {
                case 0:
                    txtAppoxCoilDiameter.Text = "30";
                    txtGlobalCoilDiameter.Text = "30";
                    break;
                case 1:
                    txtAppoxCoilDiameter.Text = "40";
                    txtGlobalCoilDiameter.Text = "40";
                    break;
                case 2:
                    txtAppoxCoilDiameter.Text = "50";
                    txtGlobalCoilDiameter.Text = "50";
                    break;
                case 3:
                    txtAppoxCoilDiameter.Text = "75";
                    txtGlobalCoilDiameter.Text = "75";
                    break;
                case 4:
                    txtAppoxCoilDiameter.Text = "100";
                    txtGlobalCoilDiameter.Text = "100";
                    break;
                case 5:
                    txtAppoxCoilDiameter.Text = "110";
                    txtGlobalCoilDiameter.Text = "110";
                    break;
                case 6:
                    txtAppoxCoilDiameter.Text = "160";
                    txtGlobalCoilDiameter.Text = "160";
                    break;
                case 7:
                    txtAppoxCoilDiameter.Text = "200";
                    txtGlobalCoilDiameter.Text = "200";
                    break;
                case 8:
                    txtAppoxCoilDiameter.Text = "250";
                    txtGlobalCoilDiameter.Text = "250";
                    break;
                case 9:
                    txtAppoxCoilDiameter.Text = "315";
                    txtGlobalCoilDiameter.Text = "315";
                    break;
                case 10:
                    txtAppoxCoilDiameter.Text = "400";
                    txtGlobalCoilDiameter.Text = "400";
                    break;
            }
            updateAll();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            string input = txtApproxOutput.Text;
            input.Replace(" ", "");
            string[] splitInput = input.Split('-');
            txtGlobalWireDiameter.Text = ((double.Parse(splitInput[0]) + double.Parse(splitInput[1])) / 2).ToString().Replace(".", ",");
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBox1.Items.Count; i++)
            {
                richTextBox1.SetItemChecked(i, true);
            }
        }

        private bool expanded2 = false;

        private void btnCoilExplorer_Click(object sender, EventArgs e)
        {
            if (expanded2)
            {
                expanded2 = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                listBox1.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
            }
            else
            {
                expanded2 = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                listBox1.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputCoilExplorerChanged();
            textBox1.Select(textBox1.Text.Length, 0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            inputCoilExplorerChanged();
            textBox2.Select(textBox2.Text.Length, 0);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            inputCoilExplorerChanged();
            textBox3.Select(textBox3.Text.Length, 0);
        }

        private Coil explorerCoil;

        private void inputCoilExplorerChanged()
        {
            ParseAll();
            try
            {
                listBox1.Items.Clear();
                if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && textBox3.TextLength != 0)
                {
                    double ToploadCapacity = 0;
                    double.TryParse(txtToploadCap.Text, out ToploadCapacity);
                    explorerCoil = new Coil(double.Parse(textBox1.Text), double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text))
                    {
                        ToroidCapacity = ToploadCapacity,
                        ToLoFa = double.Parse(txtToLoFa.Text)
                    };
                    listBox1.Items.Add("Coil Diameter: " + explorerCoil.CoilDiameter + "mm");
                    listBox1.Items.Add("Coil Length: " + explorerCoil.CoilLength + "mm");
                    listBox1.Items.Add("Ratio: " + explorerCoil.Ratio.ToString("#.#"));
                    listBox1.Items.Add("Wire Diameter: " + explorerCoil.WireDiameter + "mm");
                    listBox1.Items.Add("Wire Spacing: " + explorerCoil.WireSpacing + "mm");
                    listBox1.Items.Add("Wire Length: " + explorerCoil.WireLength.ToString("#.#") + "m");
                    listBox1.Items.Add("Turns: " + explorerCoil.Turns.ToString("#.#"));
                    listBox1.Items.Add("Inductance: " + explorerCoil.Inductance.ToString("#.#") + "uH");
                    listBox1.Items.Add("Toroid Major Diameter: " + explorerCoil.ToroidMajorDiameter.ToString("#.#") + "mm");
                    listBox1.Items.Add("Toroid Minor Diameter: " + explorerCoil.ToroidMinorDiameter.ToString("#.#") + "mm");
                    listBox1.Items.Add("Topload Capacity: " + explorerCoil.ToroidCapacity.ToString("#.#") + "pF");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Frequency: " + explorerCoil.Frequency.ToString("#.#") + "kHz");
                    listBox1.Items.Add("real Frequency depends on the sparks loading the coil");
                    listBox1.Items.Add("Impedance: " + explorerCoil.Impedance.ToString("#.#") + "Ohm");
                    listBox1.Items.Add("Reactance: " + explorerCoil.ReactanceAtResonance.ToString("#.#") + "Ohm");
                    listBox1.Items.Add("Both use a different Formular");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("DC Resistance: " + explorerCoil.DCResistance.ToString("#.#") + "Ohm");
                    listBox1.Items.Add("AC Resitance: " + explorerCoil.ACResistance.ToString("#.#") + "Ohm");
                    listBox1.Items.Add("Q unloaded: " + explorerCoil.qUnloaded.ToString("#.#"));
                    listBox1.Items.Add("Quarter Wave Length: " + (explorerCoil.QuarterWaveLength / 1000).ToString("#.#") + "m :)");
                    //listBox1.Items.Add(": " + explorerCoil.);
                }
            }
            catch
            {

            }
        }

        private void txtToLoFa_TextChanged(object sender, EventArgs e)
        {
            txtToLoFa.Select(txtToLoFa.Text.Length, 0);
            updateAll();
        }

        public void updateAll()
        {
            ParseAll();
            inputCoilExplorerChanged();
            btnGlobalCalc.PerformClick();
            btnApprox.PerformClick();
        }

        private void txtFilterFrequency_TextChanged(object sender, EventArgs e)
        {
            txtFilterFrequency.Select(txtFilterFrequency.Text.Length, 0);
            updateAll();
        }

        private void txtUpAccIm_TextChanged(object sender, EventArgs e)
        {
            txtUpAccIm.Select(txtUpAccIm.Text.Length, 0);
            updateAll();
        }

        private void txtLoAccIm_TextChanged(object sender, EventArgs e)
        {
            txtLoAccIm.Select(txtLoAccIm.Text.Length, 0);
            updateAll();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            inputCoilExplorerChanged();
            textBox4.Select(textBox4.Text.Length, 0);
        }

        private void txtEnamThick_TextChanged(object sender, EventArgs e)
        {
            txtEnamThick.Select(txtEnamThick.Text.Length, 0);
            updateAll();
            textBox4.Text = txtEnamThick.Text;
        }

        private void txtToploadCap_TextChanged(object sender, EventArgs e)
        {
            txtToploadCap.Select(txtToploadCap.Text.Length, 0);
            updateAll();
        }

        private void ParseAll()
        {
            txtAppoxCoilDiameter.Text = txtAppoxCoilDiameter.Text.Replace('.', ',');
            txtGlobalCoilDiameter.Text = txtGlobalCoilDiameter.Text.Replace('.', ',');
            txtGlobalWireDiameter.Text = txtGlobalWireDiameter.Text.Replace('.', ',');
            textBox1.Text = textBox1.Text.Replace('.', ',');
            textBox2.Text = textBox2.Text.Replace('.', ',');
            textBox3.Text = textBox3.Text.Replace('.', ',');
            textBox4.Text = textBox4.Text.Replace('.', ',');
            txtFilterFrequency.Text = txtFilterFrequency.Text.Replace('.', ',');
            txtUpAccIm.Text = txtUpAccIm.Text.Replace('.', ',');
            txtLoAccIm.Text = txtLoAccIm.Text.Replace('.', ',');
            txtUpAccRa.Text = txtUpAccRa.Text.Replace('.', ',');
            txtLoAccRa.Text = txtLoAccRa.Text.Replace('.', ',');
            txtToLoFa.Text = txtToLoFa.Text.Replace('.', ',');
            txtEnamThick.Text = txtEnamThick.Text.Replace('.', ',');
            txtToploadCap.Text = txtToploadCap.Text.Replace('.', ',');
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            updateAll();
        }
    }
}
