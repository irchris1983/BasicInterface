using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterface
{
    interface IAccess
    {
        string Open();
        string Close();
        string Read();
        string Write();        
    }
}
