using System;
class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }

    public Person(string name, int age)
        : this(name, age, null) { }

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
                throw new ArgumentNullException("Name is mandatory");
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
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Age must be in range 1-100");
            }

            this.age = value;
        }
    }

    public string Email 
    {
        get
        {
            return this.email;
        }
        set
        {
            if (String.IsNullOrEmpty(value) || value == "")
            {
                this.email = "non given";
            }
            else if (!value.Contains("@"))
            {
                throw new ArgumentException("Email must contain \"@\"");
            }

            this.email = value;
        }
    }

    public override string ToString()
    {
        return String.Format("Name: {0}\nAge: {1}\nEmail: {2}", this.Name, this.Age, this.Email);
    }

}
