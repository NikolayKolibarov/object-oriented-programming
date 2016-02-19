using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FractionCalculator
{
    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            long gcd =
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }

            set
            {
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("The Denominator can't be zero");
                }
                this.denominator = value;  
            }
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
     
                a.Numerator *= b.Denominator;
                b.Numerator *= a.Denominator;
                long gcd = b.Denominator * a.Denominator;
            

            return new Fraction(a.Numerator + b.Numerator, gcd);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {

                a.Numerator *= b.Denominator;
                b.Numerator *= a.Denominator;
                long gcd = b.Denominator * a.Denominator;
            

            return new Fraction(a.Numerator - b.Numerator, gcd);
        }

        public override string ToString()
        {
            return String.Format("{0}", (double)this.Numerator / this.Denominator);
        }
    }
}
