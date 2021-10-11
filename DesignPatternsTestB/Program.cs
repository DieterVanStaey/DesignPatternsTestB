using System;
using System.IO;

namespace DesignPatternsTestB
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Eiland eiland = Eiland.GetInstance();
                InwonerFactory factory = InwonerFactory.GetInstance();
                string regel;
                using StreamReader reader = new StreamReader("inwoners.txt");
                while ((regel = reader.ReadLine()) != null)
                {
                    eiland.AddInwoner(factory.maakInwoner(regel));
                }
                eiland.DeleteInwoner(1);
                eiland.vulkaan.Uitbarsten();
            }
            catch (IOException)
            {
                Console.WriteLine("Fout bij laden bestand");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
