using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    public class main
    {
        static void Main(string[] args)
        {
            Auto a = new Auto("Audi_6", "Kombi", 240, 45000);
            Auto b = new Auto("BMW_M3", "Cupe", 255, 49000);
            Auto v = new Auto("VW", "Limusine", 140, 25000);
            Motorrad d = new Motorrad("Yamaha", "UTtzh", 15, 4000);

            //Testweise Member der Objekte ausgeben
            Console.WriteLine("Preis von Motorrad d der Marke {0} zum Zeitpunkt 1: {1}", d.Marke, d.Preis);
            Console.WriteLine("Preis von Auto a der Marke {0} zum Zeitpunkt 1: {1}", a.Marke, a.Preis);
            Console.WriteLine("Preis von Auto b der Marke {0} zum Zeitpunkt 1: {1}", b.Marke, b.Preis);
            Console.WriteLine("Preis von Auto c der Marke {0} zum Zeitpunkt 1: {1}", v.Marke, v.Preis);

            //Preis für ein Objekt mit UpdatePrice ändern und aktualisierten preis ausgeben
            Console.WriteLine("\nBitte neuen Preis für Auto a schreiben:");
            decimal a_preis = Convert.ToDecimal(Console.ReadLine());
            a.UpdatePreis(a_preis);
            Console.WriteLine("\nPreis von Auto a der Marke {0} zum Zeitpunkt 2: {1}\n", a.Marke, a.Preis);

            var fahrzeugitems = new IFahrzeug[]
            {
                new Auto ("Audi_4", "Coupe", 300, 50000),
                new Auto ("Tesla_S", "Limousine", 360, 85000),
                new Auto("Ferrari", "Coupe", 500, 250000),
                new Motorrad("KTM", "2", 15, 4500)
            };

            //Zufallszahl initialisieren, mit foreach-Loop das Array durchgehen, 
            //UpdatePrice mit Zufallszahl aufrufen und in Konsole ausgeben
            Random rnd = new Random();

            foreach (var i in fahrzeugitems)
            {
                i.UpdatePreis(rnd.Next(1, 1000));
                Console.WriteLine("Zufallspreis für {0} ist {1}", i.Marke, i.Preis);
            }

        }
    }
}