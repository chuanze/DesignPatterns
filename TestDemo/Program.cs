using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            B1 b1 = new B1();
            B2 b2 = new B2();
            b1.Print();
            b2.Print();
            Console.WriteLine();
            A ab1 = new B1();
            A ab2 = new B2();
            ab1.Print();
            ab2.Print();
            Console.WriteLine();
            B1 b3 = (B1)ab1;
            b3.Say();
            Console.ReadKey();
        }
    }
    class A
    {
        public virtual void Print() { Console.WriteLine("A"); }
    }
    class B1 : A
    {
        public override void Print()
        {
            Console.WriteLine("B1");
        }
        public void Say()
        {
            Console.WriteLine("HI,I am B!");
        }
    }
    class B2:A
    {
        public new void Print() { Console.WriteLine("B2"); }
    }
}
