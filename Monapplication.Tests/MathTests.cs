using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Monapplication.Tests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]

        public void Factorielle_AvecValeur3_Retourne6()
        {
            int valeur = 3;
            int resultat = Math.Factorielle(valeur);
            Assert.AreEqual(6, resultat);
        }

        [TestMethod]
        public void Factorielle_AvecValeur10_Retourne1()
        {
            int valeur = 10;
            int resultat = Math.Factorielle(valeur);
            Assert.AreEqual(1, resultat, "La valeur doit être égale à 1");
        }
    }
}
    

