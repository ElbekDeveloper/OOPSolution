using System;

namespace OOPDemoLibrary
{
    public class AccessDemo
    {
        // Member is accessible inside the type only. This is the default.
        private void PrivateModifier()
        {
            Console.WriteLine("This is Private demo");
        }
        //Member is accessible everywhere.
        public void PublicModifier()
        {
            Console.WriteLine("This is Public demo");
        }
        //Member is accessible inside the type and any type in the same
        //assembly
        internal void InternalModifier()
        {
            Console.WriteLine("This is Internal demo");
        }
        //Member is accessible inside the type and any type that inherits from
        //the type.
        protected void ProtectedModifier()
        {
            Console.WriteLine("This is Protected demo");
        }
        //Member is accessible inside the type, any type in the same
       //  assembly, and any type that inherits from the type.
        protected internal void InternalProtectedModifier()
        {
            Console.WriteLine("This is  Internal Protected demo");
        }
        //Member is accessible inside the type, or any type that inherits from
        //the type and is in the same assembly.
        private protected void PrivateProtectedModifier()
        {
            Console.WriteLine("This is Private Protected demo");
        }
    }
}
