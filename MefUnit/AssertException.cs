using System;

namespace MefUnit
{
    public class AssertException : Exception
    {
        public AssertException(string message) : base(message)
        {
            
        }
    }
}