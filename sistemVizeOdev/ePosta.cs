using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemVizeOdev
{
    public class ePosta: ePostaMain
    {
        public override IePostaOlusturucu ePostaUret(string type)
        {
            switch (type)
            {
                case "BROSÜR":
                case "brosür":
                    return new brosürEposta();

                case "HABER":
                case "haber":
                    return new haberEposta();

                case "KAMPANYA":
                case "kampanya":
                    return new kampanyaEposta();

                default: return null;
            }
        }
    }
}
