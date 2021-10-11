using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTestB
{
    public class Zoogdier : IInwoner
    {
        public string Naam { get; set; }
        public Zoogdier(string naam)
        {
            Naam = naam;
        }
        public void Vluchten()
        {
            Console.WriteLine($"{Naam} vlucht in zijn hol");
        }
    }
}
