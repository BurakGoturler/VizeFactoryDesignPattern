using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemVizeOdev
{
    public class kampanyaEposta: IePostaOlusturucu
    {
        public void ePosta(string mail)
        {
            Console.WriteLine($"Kampanya için e-posta : {mail}@gmail.com");
        }
    }
}
