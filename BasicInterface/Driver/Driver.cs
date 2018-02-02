using BasicInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicInterface
{
    public abstract class Driver : IAccess, ITest
    {
        //virtual gives the option to override but must have a default action
        //abstract means function has to be overridden
        public virtual string Close()
        {
            return "Driver Close";
        }

        public abstract string Open();     
        public abstract string Read();        
        public abstract string Write();

        public abstract string calc();
    }
}
