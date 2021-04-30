using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public abstract class Animal
    {
        public float Weight { get; set; }
        public string Color { get; set; }
        public Animal(string color,float weight)
        {
            Weight = weight;
            Color = color;
        }
        public abstract string MakeSound();
    }
   public abstract class AnimalWithTail : Animal
    {
        public float TallLength { get; set; }
        public AnimalWithTail(string color, float weight, float tallLength) : base(color, weight)
        {
            TallLength = tallLength;
        }

    }
    public class Cat : AnimalWithTail
    {
        public Cat(string color,float weight,float tallLength):base(color,weight,tallLength)
        {

        }
        private string Purr()
        {
            return "purrrrrrr";
        }
        private string Meow()
        {
            return "meow";
        }
        public override string MakeSound()
        {
            return Purr() + Meow();
        }
        public override string ToString()
        {
            return $"This is a Cat. Color={Color},Weight={Weight},TallLength{TallLength}";
        }
    }
    public class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tallLength) : base(color, weight, tallLength) { }

        public override string MakeSound()
        {
            return "Woof";
        }
        public override string ToString()
        {
            return $"This is a Dog. Color={Color},Weight={Weight},TallLength{TallLength}";
        }
    }

}
