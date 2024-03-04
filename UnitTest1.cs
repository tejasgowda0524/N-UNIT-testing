using demo1;
namespace demo21
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 30;
            int b = 20;
            int c = a+b;
            int d = a-b;
            int expected = 30+20;
            int expexted2 = 30-20;
            var val = new Program();
            int m = val.addition(a, b);
            Assert.AreEqual(expected, c);

        }
    }
}