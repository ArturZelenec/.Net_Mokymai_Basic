namespace P017_Fot_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var fake = 45;
            var expected = "101101";
            var actual = P017_For_Uzduotys.Program.IntegerToBinare();
            Assert.AreEqual(expected, actual);
        }
    }
}