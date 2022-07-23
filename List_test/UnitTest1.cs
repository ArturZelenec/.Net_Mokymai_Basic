using List_Uzdavinai;
namespace List_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DidziausisSarase_Test()
        {
            var fake = new List<int>{ 5, 1, 6, 8, 7 };
            var expected = 8;
            var actual = Program.DidziausisSarase(fake);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DidesnisUzDidziausia_Test()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected =new List<int>{ 5, 1, 6, 8, 7, 9 };
            var actual = Program.DidesnisUzDidziausia(fake);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}