using System;

namespace Task4
{
    public interface IFahrzeug
    {
        string Marke { get; set; }
        string Modell { get; set; }
        int PS { get; set; }
        decimal Preis { get; set; }

        void UpdatePreis(decimal newprice);
    }
}
