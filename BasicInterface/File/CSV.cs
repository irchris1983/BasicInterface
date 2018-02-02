using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface.File
{
    class CSV : File
    {
        private string Filename { get; set; }

        public CSV(string filename)
        {
            Filename = filename;
        }
        public override string Close()
        {
            return "Closing csv file";
        }

        public override string Open()
        {
            return Filename;
        }

        public override string Read()
        {
            return "Reading from csv file";
        }

        public override string Write()
        {
            return "Writing to csv file";
        }
    }
}
