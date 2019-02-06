using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    abstract class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }

        abstract public void MakeSound();

        
             
                     

        public override string ToString()
        {
            return $"Animal type : {this.name}";
        }
    }

  
}
