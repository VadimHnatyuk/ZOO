using System;

namespace ZOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat John = new Cat("Green", 18, 16);
            Console.WriteLine(John.ToString());
            Dog Fedor = new Dog("White", 23, 63);
            Console.WriteLine(Fedor.ToString());
        }
    }
    
}
