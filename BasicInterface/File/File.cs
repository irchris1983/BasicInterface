using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface.File
{
    public abstract class File : IAccess
    {
        public abstract string Open();
        public abstract string Close();
        public abstract string Read();
        public abstract string Write();
        
    }
}
