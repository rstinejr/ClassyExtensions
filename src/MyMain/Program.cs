using System;
using MyExtensions;
using MyPocos;

namespace MyMain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The definition of class Foo, its c'tor, and member FooNum come frome MyPocos.
            // The metho PlusOne is added by MyExtensions.  If that package is not inlcuded,
            // this code will not compile.

            Foo foo42 = new Foo(42);
            Foo foo99 = new Foo(99);

            Console.WriteLine($"FooNum of foo42 is {foo42.FooNum}, PlusOne is {foo42.PlusOne()}");
            Console.WriteLine($"FooNum of foo99 is {foo99.FooNum}, PlusOne is {foo99.PlusOne()}");

            // A user can create extensions for System classes.
            Console.WriteLine($"PlusOne of 0 is {0.PlusOne()}, PlusOne of 31415 is {31415.PlusOne()}");
        }
    }
}
