using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemVizeOdev
{
    public class brosürEposta : IePostaOlusturucu
    {
        public void ePosta(string mail)
        {
            Console.WriteLine($"Broşür için e-posta : {mail}@gmail.com");
        }
    }
}
