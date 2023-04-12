using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemVizeOdev
{
    public class Program
    {
        static void Main(string[] args)
        {
            ePostaMain ePosta = new ePosta();

            IePostaOlusturucu brosür = ePosta.ePostaUret("brosür");
            IePostaOlusturucu haber = ePosta.ePostaUret("haber");
            IePostaOlusturucu kampanya = ePosta.ePostaUret("kampanya");

            brosür.ePosta("brosür");
            haber.ePosta("haber");
            kampanya.ePosta("kampanya");

            Console.Read();
        }
    }
}