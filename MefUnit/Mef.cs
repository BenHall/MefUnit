using System;
using System.ComponentModel.Composition;

namespace MefUnit
{
    public class Mef : ExportAttribute
    {
        public Mef() : base("Mef", typeof(Action))
        {
            
        }
    }
}