using System;
using System.ComponentModel.Composition;

namespace MefUnit
{
    public class MefTests : ImportAttribute
    {
        public MefTests() : base("Mef", typeof(Action))
        {
            AllowRecomposition = true;
        }
    }
}