using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DesignPatternsTestB
{
    public class Eiland
    {
        public List<IInwoner> Inwoners = new List<IInwoner>();
        public Vulkaan vulkaan = Vulkaan.GetInstance();
        private static Eiland _eiland;
        private Eiland()
        {

        }
        public static Eiland GetInstance()
        {
            if (_eiland == null)
            {
                _eiland = new Eiland();
            }

            return _eiland;
        }

        public void AddInwoner(IInwoner inwoner)
        {
            Inwoners.Add(inwoner);
            vulkaan.VulkaanUitbarstingGebeurt += inwoner.Vluchten;
        }

        public void DeleteInwoner(int getal)
        {
            vulkaan.VulkaanUitbarstingGebeurt -= Inwoners[getal].Vluchten;
            Inwoners.Remove(Inwoners[getal]);
        }
    }
}
