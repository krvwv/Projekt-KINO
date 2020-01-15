using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_KINO
{
    [Serializable]
    public class DaneBiletu
    {
        private double cenaBiletu;
        public double CenaBiletu { get => cenaBiletu; set => cenaBiletu = value; }
        public DaneBiletu(double cenaBiletu)
        {
            CenaBiletu = cenaBiletu;
        }
        public virtual double KosztBiletu()
        {
            return CenaBiletu;
        }
    }
}
