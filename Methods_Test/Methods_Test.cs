namespace Methods_Test
{
    [TestClass]
    public class Methods_Test
    {
        [TestMethod]
        public void BetKoksTekstas_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = Method_Uzdavinai.Program.BetKoksTekstas(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BeTarpu_Test1()
        {
            var fake = " a mo ";
            var expected = 4;
            var actual = Method_Uzdavinai.Program.BeTarpu(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Tarpugale_Test1()
        {
            var fake = " a mo ";
            var expected = 1;
            var actual = Method_Uzdavinai.Program.Tarpugale(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpuPriekije_Test1()
        {
            var fake = " a mo ";
            var expected = 1;
            var actual = Method_Uzdavinai.Program.TarpuPriekije(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpuPriekijeIrGale_Test1()
        {
            var fake = " a mo ";
            var expectedPriekyje = 1;
            var expectedGale = 1;

            var actual = Method_Uzdavinai.Program.TarpuPriekijeIrGale(fake,  out int actualGale);
            Assert.AreEqual(expectedPriekyje, actual);
            Assert.AreEqual(expectedGale, actualGale);
        }
    }
}