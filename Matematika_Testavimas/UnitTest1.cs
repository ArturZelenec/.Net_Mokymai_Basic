namespace Matematika_Testavimas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //fake
            var a = 3;
            var b = 2;
            //expected
            var expected = 1.5;
            //actual
            var actual = Uzdavinys_Matematika.Program.Skaiciatuvas(a,b,"/");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var a = 10;
            var b = 5;
            var expected = 50;
            var actual = Uzdavinys_Matematika.Program.Skaiciatuvas(a, b, "*");
            Assert.AreEqual(expected, actual);
        }
    }
}