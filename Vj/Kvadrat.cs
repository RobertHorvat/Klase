using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vj
{
    class Kvadrat
    {
        private double stranica;
        private double opseg;
        private double povrsina;

        private void IzracunajOpseg()
        {
            opseg = 4 * stranica;
        }

        private void IzracunajPovrsinu()
        {
            povrsina = stranica * stranica;
        }

        public void ZadajStranicu(double stranica)
        {
            this.stranica = stranica;
            IzracunajOpseg();
            IzracunajPovrsinu();
        }

        public string VratiOpis()
        {
            return string.Format("Kvadrat ima:\na)Stranicu: {0}\nb)Opseg: {1}\nc)Povrsinu: {2}", stranica, VratiOpseg(), VratiPovrsinu());
        }

        public double VratiOpseg()
        {
            return 4 * stranica;
        }

        public double VratiPovrsinu()
        {
            return stranica * stranica;
        }

    }
}
