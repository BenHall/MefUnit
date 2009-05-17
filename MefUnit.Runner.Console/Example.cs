namespace MefUnit.Runner.Console
{
    public class Example
    {
        [Mef]
        public void Test1()
        {
            throw new AssertException("Test Failed");
        }

        [Mef]
        public void Test2()
        {
            throw new SkipException();
        }

        [Mef]
        public void Test3()
        {
        }
    }
}