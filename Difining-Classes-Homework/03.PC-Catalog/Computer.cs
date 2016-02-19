using System;

class Computer
{
    private string name;
    private Component processor;
    private Component hdd;
    private Component graphicsCard;
    private decimal price;

    public Computer(string name, Component processor, Component hdd, Component graphicsCard, decimal price)
    {
        this.Name = name;
        this.Price = price;
        this.Processor = processor;
        this.HDD = hdd;
        this.GraphicsCard = graphicsCard;
    }

    public Computer(string name, decimal price)
        : this(name, null, null, null, price)
    {

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
                throw new ArgumentNullException("Can't be empty");
            }
            this.name = value;
        }
    }

    public Component Processor { get; set; }

    public Component HDD { get; set; }

    public Component GraphicsCard { get; set; }

    public decimal Price 
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Price can't be zero or negative");

            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        string output = "";
        if (!String.IsNullOrEmpty(this.name))
        {
            output += "Name: " + this.Name + "\n";
        }

        output += "Price: " + this.Price + "lv" +"\n";
        output += "Processor: " + this.Processor + "\n";
        output += "HDD: " + this.HDD + "\n";
        output += "Graphics card: " + this.GraphicsCard + "\n";
        return output;
    }

    public void printConfig()
    {
        decimal totalPrice = Processor.Price + GraphicsCard.Price + HDD.Price;
        Console.WriteLine("Computer name: {0}\nProcessor {1}\nHDD {2}\nGraphics Card {3}\nTotal computer price: {4}\n",
            this.Name, this.Processor, this.HDD, this.GraphicsCard, totalPrice);
    }
}

