using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_Animals.Interfaces;

namespace _2_Animals.Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.gender = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\nAge: {1}\nGender: {2}", this.Name, this.Age, this.Gender);
        }

        public int GetAverageAge(Animal animal)
        {
            int averageAge = 0;
            Type animalType = animal.GetType();
            string animalTypeStr = animalType.ToString();
            switch (animalTypeStr)
            {
                case "_2_Animals.Animals.Cat": averageAge = 15;
                    break;
                case "_2_Animals.Animals.Kitten": averageAge = 15;
                    break;
                case "_2_Animals.Animals.Tomcat": averageAge = 15;
                    break;
                case "_2_Animals.Animals.Dog": averageAge = 13;
                    break;
                case "_2_Animals.Animals.Frog": averageAge = 12;
                    break;
                default:
                    break;
            }
            return averageAge;
        }

        public abstract void ProduceSound(Animal animal);
    }
}
