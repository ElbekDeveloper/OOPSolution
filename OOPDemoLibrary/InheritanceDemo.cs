using System;
using System.Collections.Generic;
using System.Text;

namespace OOPDemoLibrary
{
   public  class InheritanceDemo : AccessDemo
    {
        public void Test()
        {
            PublicModifier();
            ProtectedModifier();
            InternalModifier();
            InternalProtectedModifier();
            PrivateProtectedModifier();
        }
    }
}
