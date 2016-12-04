using System;

namespace MyPocos
{
    public class Foo 
    {
        public Foo(Int32 num)
        {
            FooNum = num;
        }

        public Int32 FooNum { get; set; }

        public void Hello()
        {
            Console.WriteLine($"Hello from Foo {FooNum}!");
        }
    }
}
