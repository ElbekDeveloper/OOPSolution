using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemoLibrary
{
    public class Caller
    {
        public void CallerMethod()
        {
            AccessDemo demo = new AccessDemo();

            demo.InternalModifier();
            demo.InternalProtectedModifier();
        }
    }
}
