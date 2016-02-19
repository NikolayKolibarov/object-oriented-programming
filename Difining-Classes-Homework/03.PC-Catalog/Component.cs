using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Component
{
    private string name;
    private string details;
    private decimal price;

    public Component(string name, string details, decimal price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }

    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
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
                throw new ArgumentNullException("Name can't be empty");
            }
            this.name = value;
        }
    }

    public string Details
    {
        get
        {
            return this.details;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Details can't be empty");
            }
            this.details = value;
        }
    }

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

        if (!String.IsNullOrEmpty(this.details))
        {
            output += "Details: " + this.Details + "\n";
        }

        output += "Price: " + this.Price + "lv" + "\n";

        return output;
    }
}

