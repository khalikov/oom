using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
   public class Auto : IFahrzeug
    {

        private string m_marke;
        private string m_modell;
        private int m_ps;
        private decimal m_preis;

        public string Marke
        {
            get
            {
                return m_marke;
            }

            set
            {
                m_marke = value;
            }
        }

        public string Modell
        {
            get
            {
                return m_modell;
            }

            set
            {
                m_modell = value;
            }
        }

        public int PS
        {
            get
            {
                return m_ps;
            }

            set
            {
                m_ps = value;
            }
        }

        public decimal Preis
        {
            get
            {
                return m_preis;
            }

            set
            {
                m_preis = value;
            }
        }

        public Auto(string Marke, string Modell, int PS, decimal Preis)
        {
            if (Preis < 0) throw new ArgumentOutOfRangeException("Preis darf nicht kleiner 0 sein.");

            m_marke = Marke;
            m_modell = Modell;
            m_ps = PS;
            m_preis = Preis;
        }

        public void UpdatePreis(decimal neupreis)
        {
            if (neupreis < 0) throw new ArgumentOutOfRangeException("Preis darf nicht kleiner 0 sein.");

            m_preis = neupreis;
        }
    }
}
