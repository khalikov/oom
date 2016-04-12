using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task4
{
    public class main
    {
        static void Main(string[] args)
        {
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
            }

            Serialization.Run(fahrzeugitems);
        }
    }
}