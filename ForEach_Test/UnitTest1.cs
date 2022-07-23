using ForEach_uzdaviniai;
namespace ForEach_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Vidurkis_test()
        {
            var fake = new List<int>() { 5,1,6,8,7 };
            var expected = 5.4;
            var actual = Program.Vidurkis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrintiSkaiciausTeigiamuma_test()
        {
            var fake = new List<int>() { -5, 1 };
            var expected = new List<string> { "Neigiamas", "Teigiamas"};
            var actual = Program.TikrintiSkaiciausTeigiamuma(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ApskaiciotiGPM_test()
        {
            var gpm = 15;
            var fake = new List<double>() { 100, 150, 188.88, 153.87, 68.68 };
            var expected = 661.58d;
            var actual = Program.ApskaiciotiGPM(fake, gpm);
            Assert.AreEqual(expected, actual);
        }
    }
}