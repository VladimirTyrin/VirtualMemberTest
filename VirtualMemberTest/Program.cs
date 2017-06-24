using System;

namespace VirtualMemberTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new Child();
        }
    }

    internal class Parent
    {
        public Parent()
        {
            Foo();
        }

        public virtual void Foo()
        {
            Console.WriteLine("Hello from parent");
        }
    }

    internal class Child : Parent
    {
        private readonly string _world;

        public Child()
        {
            _world = "WORLD";
        }

        public override void Foo()
        {
            Console.WriteLine($"Hello, {_world.ToLowerInvariant()}");
        }
    }
}
