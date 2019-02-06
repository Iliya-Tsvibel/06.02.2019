using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Poodle : Dog
    {
        public int numberOfPunyTails;

        public Poodle(string name, string favoriteDogFood, int numberOfPunyTails) :base(name, favoriteDogFood)
        {
            this.numberOfPunyTails = numberOfPunyTails;
        }

        public override void Bark()
        {
            Console.WriteLine("Buhat!");
        }

        public override string ToString()
        {
            return $"Number Of Puny Tails : {numberOfPunyTails} {base.ToString()}";
        }

    }

   

    
}
