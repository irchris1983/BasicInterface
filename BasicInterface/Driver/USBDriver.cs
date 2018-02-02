using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface
{
    class USBDriver : Driver, IAccess
    {
        public string ComPort { get; set; }

        public override string Open()
        {
            return "USB connection open";
        }

        public override string Close()
        {            
            return "USB connection closed";
        }

        public override string Read()
        {
            return "Reading from USB device";
        }

        public override string Write()
        {
            return "Writing to USB device";
        }

        public override string calc()
        {
            return "This is a test for the use of a second interface with the USB base class";
        }
    }
}
