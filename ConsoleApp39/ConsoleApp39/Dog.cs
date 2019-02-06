using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Dog : Animal
    {
      
        public string favoriteDogFood;

     
        
        

        public Dog(string name, string favoriteDogFood) :base(name)
        {
            
            this.favoriteDogFood = favoriteDogFood;
        }

        public virtual void Bark()
        {
            Console.WriteLine("Gav-Gav");

        }

        public override void MakeSound()
        {
            this.Bark();
        }

        public override string ToString()
        {
            return $"Favorite dog food : {this.favoriteDogFood} {base.ToString()}";
        }
    }
}
