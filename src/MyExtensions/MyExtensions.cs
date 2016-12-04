using System;
using MyPocos;

namespace MyExtensions
{
    public static class FooExtension
    {
        public static Int32 PlusOne(this Foo foo)
        {    
            return foo.FooNum + 1;
        }
    }
}
