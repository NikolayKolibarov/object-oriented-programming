using System;
using System.Collections.Generic;
using System.Linq;
class PCCatalogMain
{
    static void Main()
    {
        Console.WriteLine("Enter computer count: ");
        int computerCount = int.Parse(Console.ReadLine());
        List<Computer> computerList = new List<Computer>();
   
        for (int i = 0; i < computerCount; i++)
        {
            string computerName, componentName, componentDetails;
            decimal computerPrice, componentPrice;
            Component processor, hdd, graphicsCard;
            
            Console.WriteLine("Enter computer name: ");
            computerName = Console.ReadLine();
            
            Console.WriteLine("Enter computer price: ");
            computerPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter processor name: ");
            componentName = Console.ReadLine();

            Console.WriteLine("Enter processor details: ");
            componentDetails = Console.ReadLine();

            Console.WriteLine("Enter processor price: ");
            componentPrice = decimal.Parse(Console.ReadLine());

            processor = new Component(componentName, componentDetails, componentPrice);

            Console.WriteLine("Enter HDD name: ");
            componentName = Console.ReadLine();

            Console.WriteLine("Enter HDD details: ");
            componentDetails = Console.ReadLine();

            Console.WriteLine("Enter HDD price: ");
            componentPrice = decimal.Parse(Console.ReadLine());

            hdd = new Component(componentName, componentDetails, componentPrice);

            Console.WriteLine("Enter graphics card name: ");
            componentName = Console.ReadLine();

            Console.WriteLine("Enter graphics card details: ");
            componentDetails = Console.ReadLine();

            Console.WriteLine("Enter graphics card price: ");
            componentPrice = decimal.Parse(Console.ReadLine());

            graphicsCard = new Component(componentName, componentDetails, componentPrice);

            computerList.Add(new Computer(computerName, processor, hdd, graphicsCard, computerPrice));
        }

        Console.WriteLine("\n");

        foreach (Computer computer in computerList)
        {
            Console.Beep();
            computer.printConfig();
        }

        List<Computer> sortedComputerList = computerList.OrderBy(computer => computer.Price).ToList();

        foreach (Computer computer in sortedComputerList)
        {
            computer.printConfig();
        }
    }
}

