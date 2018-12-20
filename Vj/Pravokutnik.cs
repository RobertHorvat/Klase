using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vj
{
    class Pravokutnik
    {
        private double stranica1;
        private double stranica2;
        private double opseg;
        private double povrsina;


        private void IzracunajPovrsinu()
        {
            povrsina = stranica1 * stranica2;
        }

        private void IzracunajOpseg()
        {
            opseg = 2 * (stranica1 + stranica2);
        }


        public void ZadajStranicu1(double stranica1)
        {
            this.stranica1 = stranica1;
            IzracunajOpseg();
            IzracunajPovrsinu();
        }

        public void ZadajStranicu2(double stranica2)
        {
            this.stranica2 = stranica2;
            IzracunajOpseg();
            IzracunajPovrsinu();
        }

        public string VratiOpis()
        {
            return string.Format("Pravokutnik ima:\na)Stranicu1: {0}\nb)Stranicu2: {1}\nc)Povrsinu: {2}\nd)Opseg: {3}", stranica1, stranica2, VratiPovrsinu(), VratiOpseg());
        }
        public double VratiOpseg()
        {
            return 2 * (stranica1 + stranica2);
        }

        public double VratiPovrsinu()
        {
            return stranica1 * stranica2;
        }
    }

}
