using System;
using System.Collections.Generic;

class PersonsMain
{
    static void Main()
    {
        int n;
        List<Person> personList = new List<Person>();
        Console.WriteLine("Enter number of persons");
        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string name, email;
            int age;
            Console.WriteLine("Enter name of person #{0}: ", i + 1);
            name = Console.ReadLine();
            Console.WriteLine("Enter age of person #{0}: ", i + 1);
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter email of person #{0}", i + 1);
            email = Console.ReadLine();

            personList.Add(new Person(name, age, email));
        }

        Console.WriteLine();

        foreach (Person person in personList)
        {
            Console.Beep();
            Console.WriteLine(person);
        }
    }
}

