using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vj
{
    class Trokut
    {
        private double stranica1;
        private double stranica2;
        private double stranica3;
        private double visina;
        private double povrsina;
        private double opseg;

        private void IzracunajOpseg()
        {
            opseg = stranica1 + stranica2 + stranica3;
        }

        private void IzracunajPovrsinu()
        {
            povrsina = (stranica1 * visina) / 2;
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

        public void ZadajStranicu3(double stranica3)
        {
            this.stranica3 = stranica3;
            IzracunajOpseg();
            IzracunajPovrsinu();
        }
        
        public void ZadajVisinu(double visina)
        {
            this.visina = visina;
            IzracunajOpseg();
            IzracunajPovrsinu();
        }

        public string VratiOpis()
        {
            return string.Format("Trokut ima:\na)Stranicu1: {0}\nb)Stranicu2: {1}\nc)Stranicu3: {2}\nd)Opseg: {3}\ne)Povrsina: {4}\nf)Visina: {5}", stranica1, stranica2, stranica3, VratiOpseg(), VratiPovrsinu(), visina);
        }

        public double VratiOpseg()
        {
            return stranica1 + stranica2 + stranica3;
        }

        public double VratiPovrsinu()
        {
            return (stranica1 * visina)/ 2;
        }

    }
}
