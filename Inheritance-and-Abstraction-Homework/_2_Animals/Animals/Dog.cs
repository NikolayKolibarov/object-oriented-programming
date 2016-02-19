using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Animals.Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }

        public override void ProduceSound(Animal animal)
        {
            Console.WriteLine("{0} barked", this.Name);
        }
    }
}
