using System;

class LaptopShopMain
{
    static void Main()
    {
        Battery acerBattery = new Battery("Qka bateriq", "20h pone");
        Laptop acerLaptop = new Laptop("Acer Aspire V15 Black Edition", "Acer", "Intel I7", "8gb", "Nvidia GeForce 860m", "128gb SSD", "15.6 ips", acerBattery, 2500);
        Console.WriteLine(acerLaptop);
    }
}

