using System;
using System.Collections.Generic;
using System.IO;

namespace Dati_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome del file sorgente: ");
            string file = $"{ Console.ReadLine()}";
            Console.WriteLine("Nome del file nuovo: ");
            string file2 = $"{ Console.ReadLine()}";
            if (File.Exists(file))
            {
                try
                {
                    using (StreamReader r = new StreamReader(file))
                    {
                        using (StreamWriter w = new StreamWriter(file2))
                        {
                            string line;
                            while ((line = r.ReadLine()) != null)
                            {
                                w.WriteLine(line);
                            }
                        }
                    }
                } catch { }
            }
            else
            {
                Console.WriteLine("Il file sorgente non esiste");
            }
        }
    }
}
