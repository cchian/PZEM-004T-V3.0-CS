using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pzem;

//นักประดิษฐ์สแตนด์อะโลน (วิโช โตเสียร)
namespace Pzem004t {
    public partial class Form1 : Form {

        private PZEM004TV30 pzem;
        public Form1() {
            InitializeComponent();
            pzem = new PZEM004TV30(this.serialPort1);
            //pzem.setAddress(0x01);
            pzem.OnUpdate += Pzem_OnUpdate;

        }

        private void Pzem_OnUpdate(object sender, PzemEvent e) {
            voltage.Text = pzem.Values.Voltage.ToString("##0.0");
            current.Text = e.Values.Current.ToString("0.000");
            power.Text = e.Values.Power.ToString("##0.0");
            energy.Text = e.Values.Energy.ToString("0.000");
            frequency.Text = e.Values.Frequency.ToString("#0.0");
            pf.Text = e.Values.PF.ToString("0.0");


            if (e.Values.Alarms == 0xFF) {
                rdAlarmOn.Checked = true;
            } else {
                rdAlarmOff.Checked = true;
            }

            float intVat = (float.Parse(energy.Text) * float.Parse(unitbaht.Text) + float.Parse(monthsv.Text)) * 7 / 100;
            vat.Text = intVat.ToString("#0.##");
            totalexp.Text = ((float.Parse(energy.Text) * float.Parse(unitbaht.Text) + float.Parse(monthsv.Text)) + intVat).ToString("##0.00");


        }

        private void CmdResetEnergy_Click(object sender, EventArgs e) {
            pzem.resetEnergy();
        }

        private void CmdSetAlarm_Click(object sender, EventArgs e) {
            pzem.setPowerAlarm(UInt16.Parse(powerAlarm.Text));
        }

        private void CmdSetAddr_Click(object sender, EventArgs e) {
            pzem.setAddress((byte)int.Parse(addr.Text));
        }

        private void Form1_Load(object sender, EventArgs e) {
            addr.Text = pzem.getAddress() + "";
            ActiveControl = cmdResetEnergy;
        }
    }
}
