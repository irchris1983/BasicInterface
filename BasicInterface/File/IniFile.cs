using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface.File
{
    class IniFile : File
    {
        public override string Close()
        {
            return "Ini file is closed";
        }

        public override string Open()
        {
            return "Ini file is open";
        }

        public override string Read()
        {
            return "Reading from ini file";
        }

        public override string Write()
        {
            return "Writing to ini file";
        }
    }
}
