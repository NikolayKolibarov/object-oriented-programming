using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    this.title = value;
                }
                catch (ArgumentNullException)
                {
                    while (String.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("The title can't be empty");
                        value = Console.ReadLine();
                        this.title = value;
                    }
                }

            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            set
            {
                try
                {
                    if (String.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    this.author = value;
                }
                catch (ArgumentNullException)
                {
                    while (String.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("You must enter an author");
                        value = Console.ReadLine();
                        this.author = value;
                    }
                }
            }
        }

        public virtual decimal Price { get; set; }

        public override string ToString()
        {
            return String.Format("Title: {0}\nAuthor: {1}\nPrice: {2}", this.Title, this.Author, this.Price);
        }
    }
}
