namespace MefUnit.Example
{
    public class Example
    {
        [Mef]
        public void Test4()
        {
            throw new AssertException("Test Failed");
        }

        [Mef]
        public void Test5()
        {
            throw new SkipException();
        }

        [Mef]
        public void Test6()
        {
        }
    }
}
