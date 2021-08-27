using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Pzem {
    // Measured values
    public class PzemValues {
        //
        // Summary:
        //     Gets or Sets the voltage, measuring range:80-260V
        //     Resolution:0.1V
        //     Measurement accuracy:0.5%
        //
        // Returns:
        //     Returns a float that represents the current measured voltage.
        //     the value still be '-1' if the master cannot read data from the slave device
        public float Voltage { get; set; }

        //
        // Summary:
        //     Gets or Sets the current, measuring range:0-10A(PZEM-004T-10A): 0-100A(PZEM-004T-100A)
        //     Starting measure current:0.01A(PZEM-004T-10A): 0.02A(PZEM-004T-100A):
        //     Resolution:0.001A
        //     Measurement accuracy:0.5%
        //
        // Returns:
        //     Returns a float that represents the current measured current.
        //     the value still be '-1' if the master cannot read data from the slave device
        public float Current { get; set; }

        //
        // Summary:
        //     Gets or Sets the Active power, measuring range:0-2.3kW(PZEM-004T-10A): 0-23kW(PZEM-004T-100A)
        //     Starting measure power:0.4W
        //     Resolution:0.1W
        //     display format:<1000W,it display one decimal, such as:999.9W: >=1000W,it display only integer, such as:1000W
        //     Measurement accuracy:0.5%
        //
        // Returns:
        //     Returns a float that represents the current measured active power.
        //     the value still be '-1' if the master cannot read data from the slave device
        public float Power { get; set; }

        //
        // Summary:
        //     Gets or Sets the Active energy, measuring range:0-9999.99kWh
        //     Resolution:1Wh
        //     display format:<10kWh, the display unit is Wh(1kWh=1000Wh), such as:9999Wh: >=10kWh, the display unit is kwH, such as:9999.99kWh
        //     Measurement accuracy:0.5%
        //
        // Returns:
        //     Returns a float that represents the current measured active energy.
        //     the value still be '-1' if the master cannot read data from the slave device
        public float Energy { get; set; }

        //
        // Summary:
        //     Gets or Sets the frequency, measuring range:45Hz-65Hz
        //     Resolution:0.1Hz
        //     Measurement accuracy:0.5%
        //
        // Returns:
        //     Returns a float that represents the current measured frequency.
        //     the value still be '-1' if the master cannot read data from the slave device
        public float Frequency { get; set; }

        //
        // Summary:
        //     Gets or Sets the power factor, measuring range:0.00-1.00
        //     Resolution:0.01
        //     Measurement accuracy:0.5%
        //
        // Returns:
        //     Returns a float that represents the current measured power factor.
        //     the value still be '-1' if the master cannot read data from the slave device
        public float PF { get; set; }

        //
        // Summary:
        //     Gets or Sets the alarm status
        //
        // Returns:
        //     Returns a float that represents the current measured power alarm status the value 0 mean not set.
        //     the value still be '-1' if the master cannot read data from the slave device
        public byte Alarms { get; set; }
    }

    //
    // Summary:
    //     Pzem-004t v3.0 class
    public class PZEM004TV30 : Pzem004t {

        //
        // Summary:
        //     Returns a string that represents the current object.
        //
        // parameters:
        //     port: System.io.ports.Serialport object
        //     addr: slave address (0x01-0xF7),  the general defualt address is 0xF8 for unknow slave adress
        // Returns:
        //     no return
        public PZEM004TV30(SerialPort port, byte addr = PZEM_DEFAULT_ADDR) {

            this.Values = new PzemValues();
            this._serial = port;
            this._serial.BaudRate = PZEM_BAUD_RATE;
            this._serial.ReadTimeout = 500;
            this._serial.Open();

            this._timer = new Timer();
            this._timer.Interval = UPDATE_TIME;
            this._timer.Tick += _timer_Tick;
            this._timer.Start();

            init(addr);
        }

        //timer task update value every time .
        private void _timer_Tick(object sender, EventArgs e) {
            updateValues();
            Update(new PzemEvent(Values));
        }

        //
        // Summary:
        //     Returns a string that represents the current object.
        //
        // Returns:
        //     A string that represents the current object.
        public int UpdateInterval {
            get { return this._timer.Interval; }
            set {
                this._timer.Interval = value;
            }
        }

        #region getValues
        //
        // Summary:
        //     Returns a float that represents the current measured voltage.
        //
        // Returns:
        //     A float that represents the current measured voltage.
        public float voltage() {
            return Values.Voltage;
        }

        //
        // Summary:
        //     Returns a float that represents the current measured current.
        //
        // Returns:
        //     A float that represents the current measured current.
        public float current() {
            return Values.Current;
        }

        //
        // Summary:
        //     Returns a float that represents the current measured power.
        //
        // Returns:
        //     A float that represents the current measured power.
        public float power() {
            return Values.Power;
        }

        //
        // Summary:
        //     Returns a float that represents the current measured energy.
        //
        // Returns:
        //     A float that represents the current measured energy.
        public float energy() {
            return Values.Energy;
        }

        //
        // Summary:
        //     Returns a float that represents the current measured frequency.
        //
        // Returns:
        //     A float that represents the current measured frequency.
        public float frequency() {
            return Values.Frequency;
        }

        //
        // Summary:
        //     Returns a float that represents the current measured power factor.
        //
        // Returns:
        //     A float that represents the current measured power factor.
        public float pf() {
            return Values.PF;
        }
        #endregion

        //
        // Summary:
        //     Returns a string that represents the current object.
        //
        // Parameters:
        //   addr:
        //     The value of byte address in range 0x01-0xF7.
        //
        // Returns:
        //     A bool that represents the operation is complease is 'true'.
        public bool setAddress(byte addr) {
            if (addr < 0x01 || addr > 0xF7) // sanity check
                return false;

            // Write the new address to the address register
            if (!sendCmd8(CMD_WSR, WREG_ADDR, addr, true))
                return false;

            _addr = addr; // If successful, update the current slave address

            return true;
        }

        //
        // Summary:
        //     Returns a byte that represents the slave address.
        //
        // Returns:
        //     A byte that represents the slave address.
        public byte getAddress() {
            return _addr;
        }

        //
        // Summary:
        //     Returns a string that represents the current object.
        //
        // Returns:
        //     A string that represents the current object.
        public bool setPowerAlarm(UInt16 watts) {
            if (watts > 25000) { // Sanitych check
                watts = 25000;
            }

            // Write the watts threshold to the Alarm register
            if (!sendCmd8(CMD_WSR, WREG_ALARM_THR, watts, true))
                return false;

            return true;
        }

        //
        // Summary:
        //     Returns a bool that represents the Alarm status.
        //
        // Returns:
        //     A bool that represents the Alarm status.
        public bool getPowerAlarm() {
            return Values.Alarms != 0x0000;
        }

        //
        // Summary:
        //     Reset active energy to factory reset
        //     Returns a bool that represents the energy measured is 0Wh.
        //
        // Returns:
        //     A bool that represents the energy measured is 0Wh
        public bool resetEnergy() {
            byte[] buffer = { 0x00, CMD_REST, 0x00, 0x00 };
            byte[] reply = new byte[5];
            buffer[0] = _addr;
            setCRC(buffer, 4);
            _serial.Write(buffer, 0, 4);

            UInt16 length = recieve(reply, 5);

            if (length == 0 || length == 5) {
                return false;
            }

            return true;
        }

        // Init common to all constructors
        private void init(byte addr) {
            if (addr < 0x01 || addr > 0xF8) // Sanity check of address
                addr = PZEM_DEFAULT_ADDR;
            _addr = addr;

            // Set initial lastRed time so that we read right away
            _lastRead = 0;
            _lastRead -= UPDATE_TIME;
        }

        protected override void Update(PzemEvent e) {
            base.Update(e);
        }

        // Get most up to date values from device registers and cache them
        private bool updateValues() {  //static uint8_t buffer[] = {0x00, CMD_RIR, 0x00, 0x00, 0x00, 0x0A, 0x00, 0x00};
            byte[] response = new byte[25];

            // Read 10 registers starting at 0x00 (no check)
            sendCmd8(CMD_RIR, 0x00, 0x0A, false);

            if (recieve(response, 25) != 25) { // Something went wrong
                Values.Voltage = 0;
                Values.Current = 0;
                Values.Power = 0;
                Values.Energy = 0;
                Values.Frequency = 0;
                Values.PF = 0;
                Values.Alarms = 0;
                return false;
            }

            // Update the current values
            Values.Voltage = (float)(((UInt32)response[3] << 8 | // Raw voltage in 0.1V
                                      (UInt32)response[4]) / 10.0);

            Values.Current = (float)(((UInt32)response[5] << 8 | // Raw current in 0.001A
                                      (UInt32)response[6] |
                                      (UInt32)response[7] << 24 |
                                      (UInt32)response[8] << 16) / 1000.0);

            Values.Power = (float)(((UInt32)response[9] << 8 | // Raw power in 0.1W
                                      (UInt32)response[10] |
                                      (UInt32)response[11] << 24 |
                                      (UInt32)response[12] << 16) / 10.0);

            Values.Energy = (float)(((UInt32)response[13] << 8 | // Raw Energy in 1Wh
                                      (UInt32)response[14] |
                                      (UInt32)response[15] << 24 |
                                      (UInt32)response[16] << 16) / 1000.0);

            Values.Frequency = (float)(((UInt32)response[17] << 8 | // Raw Frequency in 0.1Hz
                                      (UInt32)response[18]) / 10.0);

            Values.PF = (float)(((UInt32)response[19] << 8 | // Raw pf in 0.01
                                      (UInt32)response[20]) / 100.0);

            Values.Alarms = (byte)(((UInt32)response[21] << 8 | // Raw alarm value
                                      (UInt32)response[22]));


            if (Values.Voltage>260) { // Something went wrong
                Values.Voltage = 0;
                Values.Current = 0;
                Values.Power = 0;
                Values.Energy = 0;
                Values.Frequency = 0;
                Values.PF = 0;
                Values.Alarms = 0;
                return false;
            }
            // Record current time as _lastRead
            _lastRead = (ulong)DateTime.Now.Millisecond;

            return true;
        }

        // Receive len bytes into a buffer
        UInt16 recieve(byte[] resp, UInt16 len) {
            long startTime = DateTime.Now.Millisecond; // Start time for Timeout
            byte index = 0; // Bytes we have read
            while ((index < len) && (DateTime.Now.Millisecond - startTime < READ_TIMEOUT) && _serial.BytesToRead > 0) {
                byte c = (byte)_serial.ReadByte();
                resp[index++] = c;
            }

            // Check CRC with the number of bytes read
            if (!checkCRC(resp, index)) {
                return 0;
            }

            return index;
        }

        // Send 8 byte command
        private bool sendCmd8(byte cmd, UInt16 rAddr, UInt16 val, bool check = false) {
            byte[] sendBuffer = new byte[8]; // Send buffer
            byte[] respBuffer = new byte[8]; // Response buffer (only used when check is true)

            sendBuffer[0] = _addr;                   // Set slave address
            sendBuffer[1] = cmd;                     // Set command

            sendBuffer[2] = (byte)((rAddr >> 8) & 0xFF);     // Set high byte of register address
            sendBuffer[3] = (byte)((rAddr) & 0xFF);          // Set low byte =//=

            sendBuffer[4] = (byte)((val >> 8) & 0xFF);       // Set high byte of register value
            sendBuffer[5] = (byte)((val) & 0xFF);            // Set low byte =//=

            setCRC(sendBuffer, 8);                   // Set CRC of frame

            _serial.Write(sendBuffer, 0, 8); // send frame

            if (check) {
                if (0 != recieve(respBuffer, 8)) { // if check enabled, read the response
                    return false;
                }

                // Check if response is same as send
                for (byte i = 0; i < 8; i++) {
                    if (sendBuffer[i] != respBuffer[i])
                        return false;
                }
            }
            return true;
        }

        // Set the CRC for a buffer
        private void setCRC(byte[] buf, UInt16 len) {
            if (len <= 2) // Sanity check
                return;

            UInt16 crc = CRC16(buf, (UInt16)(len - 2)); // CRC of data

            // Write high and low byte to last two positions
            buf[len - 2] = (byte)(crc & 0xFF); // Low byte first
            buf[len - 1] = (byte)((crc >> 8) & 0xFF); // High byte second
        }
        // Check CRC of buffer
        private bool checkCRC(byte[] buf, UInt16 len) {
            if (len <= 2) // Sanity check
                return false;

            UInt16 crc = CRC16(buf, (UInt16)(len - 2)); // Compute CRC of data
            return ((UInt16)buf[len - 2] | (UInt16)buf[len - 1] << 8) == crc;
        }

        //Calculate CRC of buffer
        //https://www.modbustools.com/modbus_crc16.html
        private UInt16 CRC16(byte[] nData, UInt16 wLength) {
            UInt16[] wCRCTable = {
                0X0000, 0XC0C1, 0XC181, 0X0140, 0XC301, 0X03C0, 0X0280, 0XC241,
                0XC601, 0X06C0, 0X0780, 0XC741, 0X0500, 0XC5C1, 0XC481, 0X0440,
                0XCC01, 0X0CC0, 0X0D80, 0XCD41, 0X0F00, 0XCFC1, 0XCE81, 0X0E40,
                0X0A00, 0XCAC1, 0XCB81, 0X0B40, 0XC901, 0X09C0, 0X0880, 0XC841,
                0XD801, 0X18C0, 0X1980, 0XD941, 0X1B00, 0XDBC1, 0XDA81, 0X1A40,
                0X1E00, 0XDEC1, 0XDF81, 0X1F40, 0XDD01, 0X1DC0, 0X1C80, 0XDC41,
                0X1400, 0XD4C1, 0XD581, 0X1540, 0XD701, 0X17C0, 0X1680, 0XD641,
                0XD201, 0X12C0, 0X1380, 0XD341, 0X1100, 0XD1C1, 0XD081, 0X1040,
                0XF001, 0X30C0, 0X3180, 0XF141, 0X3300, 0XF3C1, 0XF281, 0X3240,
                0X3600, 0XF6C1, 0XF781, 0X3740, 0XF501, 0X35C0, 0X3480, 0XF441,
                0X3C00, 0XFCC1, 0XFD81, 0X3D40, 0XFF01, 0X3FC0, 0X3E80, 0XFE41,
                0XFA01, 0X3AC0, 0X3B80, 0XFB41, 0X3900, 0XF9C1, 0XF881, 0X3840,
                0X2800, 0XE8C1, 0XE981, 0X2940, 0XEB01, 0X2BC0, 0X2A80, 0XEA41,
                0XEE01, 0X2EC0, 0X2F80, 0XEF41, 0X2D00, 0XEDC1, 0XEC81, 0X2C40,
                0XE401, 0X24C0, 0X2580, 0XE541, 0X2700, 0XE7C1, 0XE681, 0X2640,
                0X2200, 0XE2C1, 0XE381, 0X2340, 0XE101, 0X21C0, 0X2080, 0XE041,
                0XA001, 0X60C0, 0X6180, 0XA141, 0X6300, 0XA3C1, 0XA281, 0X6240,
                0X6600, 0XA6C1, 0XA781, 0X6740, 0XA501, 0X65C0, 0X6480, 0XA441,
                0X6C00, 0XACC1, 0XAD81, 0X6D40, 0XAF01, 0X6FC0, 0X6E80, 0XAE41,
                0XAA01, 0X6AC0, 0X6B80, 0XAB41, 0X6900, 0XA9C1, 0XA881, 0X6840,
                0X7800, 0XB8C1, 0XB981, 0X7940, 0XBB01, 0X7BC0, 0X7A80, 0XBA41,
                0XBE01, 0X7EC0, 0X7F80, 0XBF41, 0X7D00, 0XBDC1, 0XBC81, 0X7C40,
                0XB401, 0X74C0, 0X7580, 0XB541, 0X7700, 0XB7C1, 0XB681, 0X7640,
                0X7200, 0XB2C1, 0XB381, 0X7340, 0XB101, 0X71C0, 0X7080, 0XB041,
                0X5000, 0X90C1, 0X9181, 0X5140, 0X9301, 0X53C0, 0X5280, 0X9241,
                0X9601, 0X56C0, 0X5780, 0X9741, 0X5500, 0X95C1, 0X9481, 0X5440,
                0X9C01, 0X5CC0, 0X5D80, 0X9D41, 0X5F00, 0X9FC1, 0X9E81, 0X5E40,
                0X5A00, 0X9AC1, 0X9B81, 0X5B40, 0X9901, 0X59C0, 0X5880, 0X9841,
                0X8801, 0X48C0, 0X4980, 0X8941, 0X4B00, 0X8BC1, 0X8A81, 0X4A40,
                0X4E00, 0X8EC1, 0X8F81, 0X4F40, 0X8D01, 0X4DC0, 0X4C80, 0X8C41,
                0X4400, 0X84C1, 0X8581, 0X4540, 0X8701, 0X47C0, 0X4680, 0X8641,
                0X8201, 0X42C0, 0X4380, 0X8341, 0X4100, 0X81C1, 0X8081, 0X4040
            };

            byte nTemp;
            UInt16 wCRCWord = 0xFFFF;
            int i = 0;
            while ((wLength--) > 0) {
                nTemp = (byte)(nData[i++] ^ wCRCWord);
                wCRCWord >>= 8;
                wCRCWord ^= wCRCTable[nTemp];
            }
            return wCRCWord;
        }

        #region class atribbute
        //measurement register result address (input register)
        const byte REG_VOLTAGE = 0x00;
        const byte REG_CURRENT_L = 0x01;
        const byte REG_CURRENT_H = 0X02;
        const byte REG_POWER_L = 0x03;
        const byte REG_POWER_H = 0x04;
        const byte REG_ENERGY_L = 0x05;
        const byte REG_ENERGY_H = 0x06;
        const byte REG_FREQUENCY = 0x07;
        const byte REG_PF = 0x08;
        const byte REG_ALARM = 0x09;

        //command address
        const byte CMD_RHR = 0x03; //read holding register. address
        const byte CMD_RIR = 0X04; //read inputer register. (see above)
        const byte CMD_WSR = 0x06; //write single register.
        const byte CMD_CAL = 0x41; //calibration.
        const byte CMD_REST = 0x42;//reset energy.

        //read and modify slave parameters.
        const byte WREG_ALARM_THR = 0x01; //power alarm threshold (1LSB corespond to 1W)
        const byte WREG_ADDR = 0x02;	  //modbus-rtu address (0x0001-0x00F7)

        const byte UPDATE_TIME = 200; 	  //timer tick interval for read data from pzem (ms)

        //const byte RESPONSE_SIZE = 32;  //read buffered size
        const byte READ_TIMEOUT = 100;	  //read timeout (exit reading loop in ms)

        const int PZEM_BAUD_RATE = 9600;  //default pzem baudrate (don't change it)

        //default address, can used 0x00 for broadcast address but the slave does not need to reply the master.
        const int PZEM_DEFAULT_ADDR = 0xF8;//0xF8 is used as the general address (The address range of the slave is 0x01-0xF7)

        public PzemValues Values;   // measured values (V,A,W,WH,Hz,PF,Alrm)

        private SerialPort _serial; // Serial interface
        private byte _addr;   		// the slave address
        private UInt64 _lastRead;   // Last time values were updated
        private Timer _timer;       // The timer for update task.
        #endregion
    }

    public class PzemEvent : EventArgs {
        public PzemValues Values;
        public PzemEvent(PzemValues val) { this.Values = val; }
    }
    public class Pzem004t {
        public event EventHandler<PzemEvent> OnUpdate;
        protected virtual void Update(PzemEvent e) {
            EventHandler<PzemEvent> handler = OnUpdate;
            if (handler != null)
                handler(this, e);
        }
    }
}
