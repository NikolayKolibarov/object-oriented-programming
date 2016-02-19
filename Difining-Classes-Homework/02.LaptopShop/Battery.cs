using System;

class Battery
{
    private string batteryType;
    private string batteryLife;

    public Battery(string battery, string batteryLife)
    {
        this.BatteryType = battery;
        this.BatteryLife = batteryLife;
    }

    public string BatteryType
    {
        get
        {
            return this.batteryType;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException();
            }
            this.batteryType = value;
        }
    }

    public string BatteryLife 
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Can't be empty");
            }
            this.batteryLife = value;
        }
    }

    public override string ToString()
    {
        string output = "";
        if (!String.IsNullOrEmpty(this.batteryType))
        {
            output += "Battery: " + this.BatteryType + "\n";
        }

        if (!String.IsNullOrEmpty(this.batteryLife))
        {
            output += "Battery life: " + this.BatteryLife + "\n";
        }

        return output;
    }
}

