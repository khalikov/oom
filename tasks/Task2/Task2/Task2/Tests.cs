using NUnit.Framework;
using System;

namespace Task4
{
    [TestFixture]
    public class HistoryTest
    {
        [Test]
        public void KannFahrzeugErstellen()
        {
            var x = new Auto("Audi_4", "Coupe", 300, 50000);

            Assert.IsTrue(x.Marke == "Audi_4");
            Assert.IsTrue(x.Modell == "Coupe");
            Assert.IsTrue(x.PS == 300);
            Assert.IsTrue(x.Preis == 50000);
        }

        [Test]
        public void UpdatePreis()
        {
            var x = new Auto("Audi_4", "Coupe", 300, 50000);

            x.UpdatePreis(6000);

            Assert.IsTrue(x.Marke == "Audi_4");
            Assert.IsTrue(x.Modell == "Coupe");
            Assert.IsTrue(x.PS == 300);
            Assert.IsTrue(x.Preis == 60000);
        }
    }
}
