using System;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Battery batteryType;
    private decimal? price;

    public Laptop()
        : this(null, null, null, null, null, null, null, null, null)
    {

    }

    public Laptop(string model, string manufacturer, string processor, string ram,
        string graphicsCard, string hdd, string screen, Battery batteryType, decimal? price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.Battery = batteryType;
        this.Price = price;
    }

    public Laptop(string model, Battery batteryType, decimal? price)
    {
        this.Model = model;
        this.Battery = batteryType;
        this.Price = price;
    }

    public Laptop(string model, decimal? price)
    {
        this.Model = model;
        this.Price = price;
    }



    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Model can't be empty.");
            }
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Can't be empty");
            }
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Can't be empty");
            }
            this.processor = value;
        }
    }

    public string Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Can't be empty");
            }
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Can't be empty");
            }
            this.graphicsCard = value;
        }

    }

    public string HDD
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Can't be empty");
            }
            this.hdd = value;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Can't be empty");
            }

            this.screen = value;
        }
    }

    public Battery Battery
    {
        get
        {
            return this.batteryType;
        }
        set
        {
            this.batteryType = value;
        }
    }

    public decimal? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Can't be negative");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        string output = "Model: " + this.Model + "\n";
        if (!String.IsNullOrEmpty(this.manufacturer))
        {
            output += "Manufacturer" + this.Manufacturer + "\n";
        }

        if (!String.IsNullOrEmpty(this.processor))
        {
            output += "Processor: " + this.Processor + "\n";
        }

        if (!String.IsNullOrEmpty(this.ram))
        {
            output += "Ram: " + this.Ram + "\n";
        }

        if (!String.IsNullOrEmpty(this.graphicsCard))
        {
            output += "Graphics card: " + this.GraphicsCard + "\n";
        }

        if (!String.IsNullOrEmpty(this.hdd))
        {
            output += "HDD: " + this.HDD + "\n";
        }

        if (!String.IsNullOrEmpty(this.screen))
        {
            output += "Screen: " + this.Screen + "\n";
        }

        output += batteryType;

        output += "Price: " + price + "\n";

        return output;
    }


}
