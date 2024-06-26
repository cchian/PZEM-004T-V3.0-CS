
# PZEM-004T-V3.0 C# Library<br> 
// This library allows you to connect your computer to the PZEM-004T V3.0 digital meter module directly via a UART-to-USB converter (without a microcontroller).<br/>
// The baud rate is 9600, with 8 data bits, 1 stop bit, and no parity.<br/>
// The new PZEM-004T version (protocol changed) uses the Modbus-RTU protocol to communicate at the application layer.<br/>
// The original library is from: https://github.com/mandulaj/PZEM-004T-v30 (C/C++ library for Arduino).<br/>


# example:
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
            Console.WriteLine("Voltage:" + e.Values.Voltage+"V");
            Console.WriteLine("Current:" + e.Values.Current+"A");
            Console.WriteLine("Active Power:" + e.Values.Power+"W");
            Console.WriteLine("Active Energy:" + e.Values.Energy+"Wh");
            Console.WriteLine("Frequency:" + e.Values.Frequency+"Hz");
            Console.WriteLine("Power Factor:" + e.Values.PF);
        }
    }
}</pre>
-------------------------------------------------------------
<br>
<p align="center">
  <img src="https://github.com/cchian/PZEM-004T-V3.0-CS/blob/master/classattib.png?raw=true" width="350" title="class attributes">
</p>
