using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemVizeOdev
{
    public abstract class ePostaMain
    {
        public abstract IePostaOlusturucu ePostaUret(string type);
    }
}