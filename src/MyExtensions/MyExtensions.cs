using System;
using MyPocos;

namespace MyExtensions
{
    public static class RandomClassName
    {
        public static Int32 PlusOne(this Foo foo)
        {    
            return foo.FooNum + 1;
        }

        public static Int32 PlusOne(this Int32 n)
        {
            return n + 1;
        }
    }
}
