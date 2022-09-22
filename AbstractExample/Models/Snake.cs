using System;

namespace AbstractExample.Models
{
    internal class Snake : Animal
    {
        public Snake(string name)
        {
            Name = name;
        }

        public Snake()
        {
            Name = "Fang";
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} Hisses & Rattles");
        }

        public override void Sleep()
        {
            Console.WriteLine("hzzzzzzz");
        }
    }
}