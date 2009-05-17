using System;
using System.Collections.Generic;

namespace MefUnit
{
    public class Framework : Extender
    {
        public Framework()
        {
            Compose();
        }

        [MefTests]
        public IEnumerable<Action> Mefs { get; set; }


        public void RunMefs()
        {
            foreach (var mef in Mefs)
            {
                Console.Write("Executing " + mef.Method.Name + "... ");

                try
                {
                    mef();
                    Console.WriteLine("Passed");
                }
                catch (AssertException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (SkipException)
                {
                    Console.WriteLine("Skipped");
                }
            }
        }
    }
}