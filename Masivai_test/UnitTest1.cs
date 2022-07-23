using Masyvas;
namespace Masivai_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RastiDidziausia()
        {
            int[] fake = new int[] { 1, 2, 3 };
            int expected = 3;
            var actual = Program.RastiDidziausia(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RikiuotiSkaiciusDidejimoTvarka2()
        {
            int[] fake = new int[] { 1, 2,9, 3, };
            int[] expected = new int[] { 1, 2, 3, 9 };
            var actual = Program.RikiuotiSkaiciusDidejimoTvarka2(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RikiuotiTrisRaides()
        {
            char[] fake = new char[] {'C', 'D', 'B' };
            char[] expected = new char[] {'B', 'C', 'D'};
            var actual = Program.RikiuotiTrisRaides(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RikiuotiKeturiasRaides()
        {
            string[] fake = new string[] {"C", "A", "B", "E" };
            string expected = "A-B-C-E";
            var actual = Program.RikiuotiKeturiasRaides(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}