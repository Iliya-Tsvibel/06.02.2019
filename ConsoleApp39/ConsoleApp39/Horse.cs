using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Horse : Animal
    {
       
        public bool racingHorse;

        public Horse(string name, bool racingHorse) : base(name)
        {
            
            this.racingHorse = racingHorse;
        }

        public override void MakeSound()
        {
            this.Neigh();
        }

        public virtual void Neigh()
        {
            Console.WriteLine("Ioooo, poehali buhat");
        }

        public override string ToString()
        {
            return $"Racing of horce : {this.racingHorse} {base.ToString()}";
        }
    }
}
