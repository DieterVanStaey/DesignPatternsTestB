using System;

namespace DesignPatternsTestB
{
    public class InwonerFactory
    {
        private static InwonerFactory deInwoners = new InwonerFactory();

        private InwonerFactory()
        {

        }

        public static InwonerFactory GetInstance() => deInwoners;
        
        public IInwoner MaakInwoner(string regel)
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
