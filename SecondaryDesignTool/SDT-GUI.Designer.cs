namespace SecondaryDesignTool
{
    partial class SDT_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SDT_GUI));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAppoxCoilDiameter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApproxRatio = new System.Windows.Forms.TextBox();
            this.btnApprox = new System.Windows.Forms.Button();
            this.txtApproxOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGlobalCoilDiameter = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGlobalWireDiameter = new System.Windows.Forms.TextBox();
            this.btnGlobalCalc = new System.Windows.Forms.Button();
            this.btnGlobalExport = new System.Windows.Forms.Button();
            this.txtOutputFilePath = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnJavaTC = new System.Windows.Forms.Button();
            this.txtToggleSettings = new System.Windows.Forms.Button();
            this.txtFilterFrequency = new System.Windows.Forms.TextBox();
            this.txtUpAccIm = new System.Windows.Forms.TextBox();
            this.txtLoAccIm = new System.Windows.Forms.TextBox();
            this.txtUpAccRa = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtToLoFa = new System.Windows.Forms.TextBox();
            this.txtLoAccRa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.trkAppoxCoilDiameter = new System.Windows.Forms.TrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnCheckAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trkAppoxCoilDiameter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get approximate Wire Diameter";
            // 
            // txtAppoxCoilDiameter
            // 
            this.txtAppoxCoilDiameter.AcceptsReturn = true;
            this.txtAppoxCoilDiameter.Location = new System.Drawing.Point(15, 36);
            this.txtAppoxCoilDiameter.Name = "txtAppoxCoilDiameter";
            this.txtAppoxCoilDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtAppoxCoilDiameter.TabIndex = 8;
            this.txtAppoxCoilDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "mm Coil Diameter";
            // 
            // txtApproxRatio
            // 
            this.txtApproxRatio.BackColor = System.Drawing.SystemColors.Window;
            this.txtApproxRatio.Location = new System.Drawing.Point(15, 110);
            this.txtApproxRatio.Name = "txtApproxRatio";
            this.txtApproxRatio.ReadOnly = true;
            this.txtApproxRatio.Size = new System.Drawing.Size(100, 20);
            this.txtApproxRatio.TabIndex = 3;
            this.txtApproxRatio.Text = "4";
            this.txtApproxRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnApprox
            // 
            this.btnApprox.Location = new System.Drawing.Point(31, 136);
            this.btnApprox.Name = "btnApprox";
            this.btnApprox.Size = new System.Drawing.Size(75, 23);
            this.btnApprox.TabIndex = 4;
            this.btnApprox.Text = "&Appoximate";
            this.btnApprox.UseVisualStyleBackColor = true;
            this.btnApprox.Click += new System.EventHandler(this.btnApprox_Click);
            // 
            // txtApproxOutput
            // 
            this.txtApproxOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtApproxOutput.Location = new System.Drawing.Point(15, 165);
            this.txtApproxOutput.Name = "txtApproxOutput";
            this.txtApproxOutput.ReadOnly = true;
            this.txtApproxOutput.Size = new System.Drawing.Size(100, 20);
            this.txtApproxOutput.TabIndex = 5;
            this.txtApproxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ømm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ratio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Get some possible Secondaries";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "mm Coil Diameter";
            // 
            // txtGlobalCoilDiameter
            // 
            this.txtGlobalCoilDiameter.Location = new System.Drawing.Point(250, 36);
            this.txtGlobalCoilDiameter.Name = "txtGlobalCoilDiameter";
            this.txtGlobalCoilDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtGlobalCoilDiameter.TabIndex = 11;
            this.txtGlobalCoilDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ømm Wirediameter";
            // 
            // txtGlobalWireDiameter
            // 
            this.txtGlobalWireDiameter.Location = new System.Drawing.Point(250, 62);
            this.txtGlobalWireDiameter.Name = "txtGlobalWireDiameter";
            this.txtGlobalWireDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtGlobalWireDiameter.TabIndex = 12;
            this.txtGlobalWireDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGlobalCalc
            // 
            this.btnGlobalCalc.BackColor = System.Drawing.Color.Transparent;
            this.btnGlobalCalc.Location = new System.Drawing.Point(250, 88);
            this.btnGlobalCalc.Name = "btnGlobalCalc";
            this.btnGlobalCalc.Size = new System.Drawing.Size(100, 23);
            this.btnGlobalCalc.TabIndex = 15;
            this.btnGlobalCalc.Text = "&Calc my Coils";
            this.btnGlobalCalc.UseVisualStyleBackColor = false;
            this.btnGlobalCalc.Click += new System.EventHandler(this.btnGlobalCalc_Click);
            // 
            // btnGlobalExport
            // 
            this.btnGlobalExport.BackColor = System.Drawing.Color.Transparent;
            this.btnGlobalExport.Location = new System.Drawing.Point(313, 334);
            this.btnGlobalExport.Name = "btnGlobalExport";
            this.btnGlobalExport.Size = new System.Drawing.Size(100, 22);
            this.btnGlobalExport.TabIndex = 16;
            this.btnGlobalExport.Text = "&Output JavaTC files";
            this.btnGlobalExport.UseVisualStyleBackColor = false;
            this.btnGlobalExport.Click += new System.EventHandler(this.btnGlobalExport_Click);
            // 
            // txtOutputFilePath
            // 
            this.txtOutputFilePath.Location = new System.Drawing.Point(15, 335);
            this.txtOutputFilePath.Name = "txtOutputFilePath";
            this.txtOutputFilePath.Size = new System.Drawing.Size(300, 20);
            this.txtOutputFilePath.TabIndex = 17;
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.SystemColors.Window;
            this.txtCount.Location = new System.Drawing.Point(358, 90);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(141, 20);
            this.txtCount.TabIndex = 18;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnJavaTC
            // 
            this.btnJavaTC.Location = new System.Drawing.Point(424, 334);
            this.btnJavaTC.Name = "btnJavaTC";
            this.btnJavaTC.Size = new System.Drawing.Size(75, 22);
            this.btnJavaTC.TabIndex = 19;
            this.btnJavaTC.Text = "JavaTC3D";
            this.btnJavaTC.UseVisualStyleBackColor = true;
            this.btnJavaTC.Click += new System.EventHandler(this.btnJavaTC_Click);
            // 
            // txtToggleSettings
            // 
            this.txtToggleSettings.BackColor = System.Drawing.Color.MidnightBlue;
            this.txtToggleSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtToggleSettings.Location = new System.Drawing.Point(447, 10);
            this.txtToggleSettings.Name = "txtToggleSettings";
            this.txtToggleSettings.Size = new System.Drawing.Size(54, 23);
            this.txtToggleSettings.TabIndex = 24;
            this.txtToggleSettings.Text = "Filters";
            this.txtToggleSettings.UseVisualStyleBackColor = false;
            this.txtToggleSettings.Click += new System.EventHandler(this.txtToggleSettings_Click);
            // 
            // txtFilterFrequency
            // 
            this.txtFilterFrequency.Location = new System.Drawing.Point(547, 10);
            this.txtFilterFrequency.Name = "txtFilterFrequency";
            this.txtFilterFrequency.Size = new System.Drawing.Size(42, 20);
            this.txtFilterFrequency.TabIndex = 25;
            this.txtFilterFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFilterFrequency.Visible = false;
            // 
            // txtUpAccIm
            // 
            this.txtUpAccIm.Location = new System.Drawing.Point(547, 36);
            this.txtUpAccIm.Name = "txtUpAccIm";
            this.txtUpAccIm.Size = new System.Drawing.Size(42, 20);
            this.txtUpAccIm.TabIndex = 26;
            this.txtUpAccIm.Text = "55000";
            this.txtUpAccIm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUpAccIm.Visible = false;
            // 
            // txtLoAccIm
            // 
            this.txtLoAccIm.Location = new System.Drawing.Point(547, 62);
            this.txtLoAccIm.Name = "txtLoAccIm";
            this.txtLoAccIm.Size = new System.Drawing.Size(42, 20);
            this.txtLoAccIm.TabIndex = 27;
            this.txtLoAccIm.Text = "45000";
            this.txtLoAccIm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoAccIm.Visible = false;
            // 
            // txtUpAccRa
            // 
            this.txtUpAccRa.Location = new System.Drawing.Point(547, 88);
            this.txtUpAccRa.Name = "txtUpAccRa";
            this.txtUpAccRa.Size = new System.Drawing.Size(42, 20);
            this.txtUpAccRa.TabIndex = 28;
            this.txtUpAccRa.Text = "4,5";
            this.txtUpAccRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUpAccRa.Visible = false;
            this.txtUpAccRa.TextChanged += new System.EventHandler(this.txtUpAccRa_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(547, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(42, 20);
            this.textBox5.TabIndex = 32;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(547, 166);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(42, 20);
            this.textBox6.TabIndex = 31;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox6.Visible = false;
            // 
            // txtToLoFa
            // 
            this.txtToLoFa.Location = new System.Drawing.Point(547, 140);
            this.txtToLoFa.Name = "txtToLoFa";
            this.txtToLoFa.Size = new System.Drawing.Size(42, 20);
            this.txtToLoFa.TabIndex = 30;
            this.txtToLoFa.Text = "0,8";
            this.txtToLoFa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtToLoFa.Visible = false;
            // 
            // txtLoAccRa
            // 
            this.txtLoAccRa.Location = new System.Drawing.Point(547, 114);
            this.txtLoAccRa.Name = "txtLoAccRa";
            this.txtLoAccRa.Size = new System.Drawing.Size(42, 20);
            this.txtLoAccRa.TabIndex = 29;
            this.txtLoAccRa.Text = "3,5";
            this.txtLoAccRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLoAccRa.Visible = false;
            this.txtLoAccRa.TextChanged += new System.EventHandler(this.txtLoAccRa_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(595, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Filter Frequency (kHz)";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(595, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Upper Acceptable Impedance (Ohm)";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(595, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Lower Acceptable Impedance (Ohm)";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(595, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Upper Acceptable Ratio";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(595, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Lower Acceptable Ratio";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(595, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Topload Factor";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(595, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "?maximal coil length?";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(595, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "other ideas?";
            this.label15.Visible = false;
            // 
            // trkAppoxCoilDiameter
            // 
            this.trkAppoxCoilDiameter.Location = new System.Drawing.Point(15, 62);
            this.trkAppoxCoilDiameter.Name = "trkAppoxCoilDiameter";
            this.trkAppoxCoilDiameter.Size = new System.Drawing.Size(104, 45);
            this.trkAppoxCoilDiameter.TabIndex = 41;
            this.trkAppoxCoilDiameter.Value = 5;
            this.trkAppoxCoilDiameter.Scroll += new System.EventHandler(this.trkAppoxCoilDiameter_Scroll);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(121, 65);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "<- cool";
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.SystemColors.Control;
            this.btnFill.Location = new System.Drawing.Point(158, 163);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(29, 23);
            this.btnFill.TabIndex = 43;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.CheckOnClick = true;
            this.richTextBox1.FormattingEnabled = true;
            this.richTextBox1.Location = new System.Drawing.Point(15, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(484, 124);
            this.richTextBox1.TabIndex = 44;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(439, 173);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(60, 23);
            this.btnCheckAll.TabIndex = 45;
            this.btnCheckAll.Text = "Check All";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // SDT_GUI
            // 
            this.AcceptButton = this.btnGlobalCalc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 365);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.trkAppoxCoilDiameter);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtToLoFa);
            this.Controls.Add(this.txtLoAccRa);
            this.Controls.Add(this.txtUpAccRa);
            this.Controls.Add(this.txtLoAccIm);
            this.Controls.Add(this.txtUpAccIm);
            this.Controls.Add(this.txtFilterFrequency);
            this.Controls.Add(this.txtToggleSettings);
            this.Controls.Add(this.btnJavaTC);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtOutputFilePath);
            this.Controls.Add(this.btnGlobalExport);
            this.Controls.Add(this.btnGlobalCalc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGlobalWireDiameter);
            this.Controls.Add(this.txtGlobalCoilDiameter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApproxOutput);
            this.Controls.Add(this.btnApprox);
            this.Controls.Add(this.txtApproxRatio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAppoxCoilDiameter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 404);
            this.Name = "SDT_GUI";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "SDT_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.trkAppoxCoilDiameter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAppoxCoilDiameter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApproxRatio;
        private System.Windows.Forms.Button btnApprox;
        private System.Windows.Forms.TextBox txtApproxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGlobalCoilDiameter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGlobalWireDiameter;
        private System.Windows.Forms.Button btnGlobalCalc;
        private System.Windows.Forms.Button btnGlobalExport;
        private System.Windows.Forms.TextBox txtOutputFilePath;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnJavaTC;
        private System.Windows.Forms.Button txtToggleSettings;
        private System.Windows.Forms.TextBox txtFilterFrequency;
        private System.Windows.Forms.TextBox txtUpAccIm;
        private System.Windows.Forms.TextBox txtLoAccIm;
        private System.Windows.Forms.TextBox txtUpAccRa;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtToLoFa;
        private System.Windows.Forms.TextBox txtLoAccRa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TrackBar trkAppoxCoilDiameter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.CheckedListBox richTextBox1;
        private System.Windows.Forms.Button btnCheckAll;
    }
}