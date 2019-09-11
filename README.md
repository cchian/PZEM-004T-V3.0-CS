# PZEM-004T-V3.0
PZEM-004T V3.0 C# Library
New PZEM-004T version (protocol changed)
the original library from: https://github.com/mandulaj/PZEM-004T-v30

example:
<pre>
using System;
using System.Windows.Forms;
using Pzem;

namespace Pzem004t {
    public partial class Demo : Form {
        public Demo() {
            InitializeComponent();
            PZEM004TV30 pz = new PZEM004TV30(new System.IO.Ports.SerialPort("COM6"));
            //pzem.setAddress(0x01);
            pz.OnUpdate += Pz_OnUpdate;
        }
        private void Pz_OnUpdate(object sender, PzemEvent e) {
            Console.WriteLine("Voltage:" + e.values.voltage);
            Console.WriteLine("Current:" + e.values.current);
            Console.WriteLine("Energy:" + e.values.energy);
            Console.WriteLine("Frequency:" + e.values.frequency);
            Console.WriteLine("Power Factor:" + e.values.pf);
        }
    }
}</pre>
