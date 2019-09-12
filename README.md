
# PZEM-004T-V3.0<br>
PZEM-004T V3.0 C# Library<br>
New PZEM-004T version (protocol changed)<br>
the original library from: https://github.com/mandulaj/PZEM-004T-v30 (library for Arduino)

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
            Console.WriteLine("Voltage:" + e.values.voltage+"V");
            Console.WriteLine("Current:" + e.values.current+"A");
            Console.WriteLine("Active Power:" + e.values.power+"W");
            Console.WriteLine("Active Energy:" + e.values.energy+"Wh");
            Console.WriteLine("Frequency:" + e.values.frequency+"Hz");
            Console.WriteLine("Power Factor:" + e.values.pf);
        }
    }
}</pre>
