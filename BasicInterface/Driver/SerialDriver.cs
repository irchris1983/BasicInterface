using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface
{
    class SerialDriver:Driver
    {
        public string Baudrate { get; set; }
        public SerialDriver(int baud)
        {
            Baudrate = baud.ToString();
        }

        public override string Open()
        {
            return Baudrate;
        }

        public override string Close()
        {
            return "Serial port is closed";
        }

        public override string Read()
        {
            return "Reading from serial port";
        }

        public override string Write()
        {
            return "Writing to serial port";
        }

        public override string calc()
        {
            return "This is a test for the use of a second interface with the Serial base class";
        }
    }
}
