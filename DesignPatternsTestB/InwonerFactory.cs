using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTestB
{
    public class InwonerFactory
    {
        private static InwonerFactory deInwoners;

        private InwonerFactory()
        {

        }

        public static InwonerFactory GetInstance()
        {
            if (deInwoners == null)
            {
                deInwoners = new InwonerFactory();
            }

            return deInwoners;
        }
        public IInwoner maakInwoner(string regel)
        {
            char letter = Convert.ToChar(regel.Substring(0, 1).ToUpper());
            string naam = regel.Substring(2);
            return letter switch
            {
                'V' => new Vogel(naam),
                'Z' => new Zoogdier(naam),
                _ => throw new Exception("Foute soort ingegeven"),
            };
        }
    }
}
