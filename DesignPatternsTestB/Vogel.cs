using System;

namespace DesignPatternsTestB
{
    public class Vogel : IInwoner
    {
        public string Naam { get; set; }
        public Vogel(string naam)
        {
            Naam = naam;
        }
        public void Vluchten()
        {
            Console.WriteLine($"{Naam} vliegt hoog weg");
        }
    }
}
