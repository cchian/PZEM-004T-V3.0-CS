namespace Pzem004t {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.voltage = new System.Windows.Forms.TextBox();
            this.current = new System.Windows.Forms.TextBox();
            this.power = new System.Windows.Forms.TextBox();
            this.energy = new System.Windows.Forms.TextBox();
            this.frequency = new System.Windows.Forms.TextBox();
            this.pf = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unitbaht = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdResetEnergy = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.monthsv = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.vat = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.totalexp = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdSetAlarm = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.powerAlarm = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cmdSetAddr = new System.Windows.Forms.Button();
            this.addr = new System.Windows.Forms.TextBox();
            this.rdAlarmOn = new System.Windows.Forms.RadioButton();
            this.rdAlarmOff = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voltage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Power";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Energy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Frequency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "PF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(121, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "W";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(121, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Wh";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(121, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Hz";
            // 
            // voltage
            // 
            this.voltage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.voltage.Location = new System.Drawing.Point(70, 19);
            this.voltage.Name = "voltage";
            this.voltage.Size = new System.Drawing.Size(47, 20);
            this.voltage.TabIndex = 2;
            this.voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // current
            // 
            this.current.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.current.Location = new System.Drawing.Point(70, 45);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(47, 20);
            this.current.TabIndex = 2;
            this.current.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // power
            // 
            this.power.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.power.Location = new System.Drawing.Point(70, 75);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(47, 20);
            this.power.TabIndex = 2;
            this.power.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // energy
            // 
            this.energy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.energy.Location = new System.Drawing.Point(70, 101);
            this.energy.Name = "energy";
            this.energy.Size = new System.Drawing.Size(47, 20);
            this.energy.TabIndex = 2;
            this.energy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frequency
            // 
            this.frequency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.frequency.Location = new System.Drawing.Point(70, 127);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(47, 20);
            this.frequency.TabIndex = 2;
            this.frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pf
            // 
            this.pf.Location = new System.Drawing.Point(70, 153);
            this.pf.Name = "pf";
            this.pf.Size = new System.Drawing.Size(47, 20);
            this.pf.TabIndex = 2;
            this.pf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdResetEnergy);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.totalexp);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.vat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.monthsv);
            this.groupBox1.Controls.Add(this.unitbaht);
            this.groupBox1.Location = new System.Drawing.Point(173, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 181);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Energy Control";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "ค่า FT (KWh/฿)";
            // 
            // unitbaht
            // 
            this.unitbaht.Location = new System.Drawing.Point(127, 23);
            this.unitbaht.Name = "unitbaht";
            this.unitbaht.Size = new System.Drawing.Size(60, 20);
            this.unitbaht.TabIndex = 2;
            this.unitbaht.Text = "2.13";
            this.unitbaht.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(193, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "฿";
            // 
            // cmdResetEnergy
            // 
            this.cmdResetEnergy.Location = new System.Drawing.Point(6, 136);
            this.cmdResetEnergy.Name = "cmdResetEnergy";
            this.cmdResetEnergy.Size = new System.Drawing.Size(203, 39);
            this.cmdResetEnergy.TabIndex = 3;
            this.cmdResetEnergy.Text = "Reset Energy/Expenses";
            this.cmdResetEnergy.UseVisualStyleBackColor = true;
            this.cmdResetEnergy.Click += new System.EventHandler(this.CmdResetEnergy_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Monthly Service";
            // 
            // monthsv
            // 
            this.monthsv.Location = new System.Drawing.Point(127, 49);
            this.monthsv.Name = "monthsv";
            this.monthsv.Size = new System.Drawing.Size(60, 20);
            this.monthsv.TabIndex = 2;
            this.monthsv.Text = "9.0";
            this.monthsv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(193, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "฿";
            // 
            // vat
            // 
            this.vat.Location = new System.Drawing.Point(127, 75);
            this.vat.Name = "vat";
            this.vat.Size = new System.Drawing.Size(60, 20);
            this.vat.TabIndex = 2;
            this.vat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "VAT (7%)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.Location = new System.Drawing.Point(193, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 18);
            this.label16.TabIndex = 0;
            this.label16.Text = "฿";
            // 
            // totalexp
            // 
            this.totalexp.ForeColor = System.Drawing.Color.Red;
            this.totalexp.Location = new System.Drawing.Point(127, 105);
            this.totalexp.Name = "totalexp";
            this.totalexp.Size = new System.Drawing.Size(60, 20);
            this.totalexp.TabIndex = 2;
            this.totalexp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Total Expenses";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label19.Location = new System.Drawing.Point(193, 105);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "฿";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.pf);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.frequency);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.energy);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.power);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.current);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.voltage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(9, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 181);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RealTime Value";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdAlarmOff);
            this.groupBox3.Controls.Add(this.rdAlarmOn);
            this.groupBox3.Controls.Add(this.addr);
            this.groupBox3.Controls.Add(this.powerAlarm);
            this.groupBox3.Controls.Add(this.cmdSetAddr);
            this.groupBox3.Controls.Add(this.cmdSetAlarm);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(399, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 178);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device";
            // 
            // cmdSetAlarm
            // 
            this.cmdSetAlarm.Location = new System.Drawing.Point(206, 18);
            this.cmdSetAlarm.Name = "cmdSetAlarm";
            this.cmdSetAlarm.Size = new System.Drawing.Size(55, 23);
            this.cmdSetAlarm.TabIndex = 0;
            this.cmdSetAlarm.Text = "Set";
            this.cmdSetAlarm.UseVisualStyleBackColor = true;
            this.cmdSetAlarm.Click += new System.EventHandler(this.CmdSetAlarm_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Power Alarm";
            // 
            // powerAlarm
            // 
            this.powerAlarm.Location = new System.Drawing.Point(78, 18);
            this.powerAlarm.Name = "powerAlarm";
            this.powerAlarm.Size = new System.Drawing.Size(74, 20);
            this.powerAlarm.TabIndex = 1;
            this.powerAlarm.Text = "0";
            this.powerAlarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(158, 23);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "W";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 53);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(106, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Set Addr (0x01-0xF7)";
            // 
            // cmdSetAddr
            // 
            this.cmdSetAddr.Location = new System.Drawing.Point(206, 48);
            this.cmdSetAddr.Name = "cmdSetAddr";
            this.cmdSetAddr.Size = new System.Drawing.Size(55, 23);
            this.cmdSetAddr.TabIndex = 0;
            this.cmdSetAddr.Text = "Set";
            this.cmdSetAddr.UseVisualStyleBackColor = true;
            this.cmdSetAddr.Click += new System.EventHandler(this.CmdSetAddr_Click);
            // 
            // addr
            // 
            this.addr.Location = new System.Drawing.Point(120, 50);
            this.addr.Name = "addr";
            this.addr.Size = new System.Drawing.Size(56, 20);
            this.addr.TabIndex = 1;
            this.addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rdAlarmOn
            // 
            this.rdAlarmOn.AutoSize = true;
            this.rdAlarmOn.Location = new System.Drawing.Point(48, 126);
            this.rdAlarmOn.Name = "rdAlarmOn";
            this.rdAlarmOn.Size = new System.Drawing.Size(68, 17);
            this.rdAlarmOn.TabIndex = 2;
            this.rdAlarmOn.Text = "Alarm On";
            this.rdAlarmOn.UseVisualStyleBackColor = true;
            // 
            // rdAlarmOff
            // 
            this.rdAlarmOff.AutoSize = true;
            this.rdAlarmOff.Checked = true;
            this.rdAlarmOff.Location = new System.Drawing.Point(141, 127);
            this.rdAlarmOff.Name = "rdAlarmOff";
            this.rdAlarmOff.Size = new System.Drawing.Size(68, 17);
            this.rdAlarmOff.TabIndex = 2;
            this.rdAlarmOff.TabStop = true;
            this.rdAlarmOff.Text = "Alarm Off";
            this.rdAlarmOff.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(123, 156);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(0, 13);
            this.label23.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 203);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PZEM-004t V3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox voltage;
        private System.Windows.Forms.TextBox current;
        private System.Windows.Forms.TextBox power;
        private System.Windows.Forms.TextBox energy;
        private System.Windows.Forms.TextBox frequency;
        private System.Windows.Forms.TextBox pf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdResetEnergy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox totalexp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox vat;
        private System.Windows.Forms.TextBox monthsv;
        private System.Windows.Forms.TextBox unitbaht;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdSetAlarm;
        private System.Windows.Forms.TextBox addr;
        private System.Windows.Forms.TextBox powerAlarm;
        private System.Windows.Forms.Button cmdSetAddr;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton rdAlarmOff;
        private System.Windows.Forms.RadioButton rdAlarmOn;
        private System.Windows.Forms.Label label23;
    }
}

