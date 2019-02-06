using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Wolf : Dog
    {


        public string nameOfPack;

        public Wolf(string name, string favoriteDogFood, string nameOfPack) : base(name, favoriteDogFood)
        {
            this.nameOfPack = nameOfPack;
        }

       

        public override string ToString()
        {
            return $"Number Of Puny Tails : {this.nameOfPack} {base.ToString()}";
        }
    }

    
}
