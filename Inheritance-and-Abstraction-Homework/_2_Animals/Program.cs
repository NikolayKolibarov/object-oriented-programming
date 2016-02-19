using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_Animals.Animals;
namespace _2_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Frog("Froggo", 5, "Male"));
            animals.Add(new Dog("Arabella", 9, "Female"));
            animals.Add(new Cat("Mark", 6, "Male"));
            animals.Add(new Kitten("Maggie", 2, "Female"));
            animals.Add(new Tomcat("Muppet", 2, "Male"));

            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].ProduceSound(animals[i]);
            }

            Console.WriteLine("------------------------------");

            IEnumerable<Animal> orderedAnimals = animals.OrderBy(animal => animal.GetAverageAge(animal));

            foreach (var animal in orderedAnimals)
            {
                Console.WriteLine(animal + "\n");
            }
        }
    }
}
