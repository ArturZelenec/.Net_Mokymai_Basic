using HangMan_Zaidimas;
namespace Hangman_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] fake = new string[] {"Vilnius"};
            string expected = "Vilnius";
            var actual = Program.RandomZodis(fake);
            Assert.AreEqual(expected, actual);
        }
        
    }
}