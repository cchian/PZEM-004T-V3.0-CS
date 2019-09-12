
# PZEM-004T-V3.0<br>
PZEM-004T V3.0 C# Library<br>
New PZEM-004T version (protocol changed) The application layer use the Modbus-RTU protocol to comunicate.<br>
the original library from: https://github.com/mandulaj/PZEM-004T-v30 (library for Arduino)

example:
<pre>
using System;
using System.Windows.Forms;
using System.IO.Ports;
using Pzem;

namespace Pzem004t {
    public partial class Demo : Form {
        public Demo() {
            InitializeComponent();
            new PZEM004TV30(new SerialPort("COM6")).OnUpdate += Pz_OnUpdate;
        }
        
        //Defualt update interval is 200ms (change it by .setInterval(int ms))
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

<br>
<p align="center">
  <img src="https://github.com/cchian/PZEM-004T-V3.0-CS/blob/master/classattib.png?raw=true" width="350" title="class attributes">
</p>
