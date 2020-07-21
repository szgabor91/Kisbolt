using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisbolt.Esemenyek
{
    public class VevoEventArgs
    {
        string messsage;

        public string Message
        {
            //get => this.messsage;
            get
            {
                return this.messsage;
            }
        }

        public VevoEventArgs(string message)
        {
            this.messsage = message;
        }
    }
}
