using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Structures_and_enums_LAB_
{
    class Program
    {
        struct Fraction
        {
            public double numerator;
            public double denominator;

            public Fraction(double numerator, double denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            public double Addition(Fraction b)
            {
                return (numerator * b.denominator) + (b.numerator * denominator) / denominator * b.denominator;
            }
            public double Subtraction(Fraction b)
            {
                return (numerator * b.denominator) - (b.numerator * denominator) / denominator * b.denominator;
            }
            public double Multiplication(Fraction b)
            {
                return (numerator * b.numerator) / (denominator * b.denominator);
            }
            public double Division(Fraction b)
            {
                return (numerator * b.denominator) / (denominator * b.numerator);
            }
        }
        struct ComplexNumbers
        {
            public double a;
            public double b;
            public ComplexNumbers(double a, double b)
            {
                this.a = a;
                this.b = b;
            }
            public string Addition(ComplexNumbers add)
            {

                a += add.a;
                b += add.b;
                return $"{a} + {b}i";
            }
            public string Subtraction(ComplexNumbers add)
            {
                a -= add.a;
                b -= add.b;
                return $"{a} - {b}i";
            }
            public string Multiplication(ComplexNumbers add)
            {
                a -= add.a;
                b -= add.b;
                double res = a * b;
                return $"{res}i";
            }
            public string Division(ComplexNumbers add)
            {
                a -= add.a;
                b -= add.b;
                double res = a / b;
                return $"{res}i";
            }


        }
        struct Birthday
        {
            DateTime YourBirthday;
            public Birthday(int day, int month, int year)
            {
                YourBirthday = new DateTime(year, month, day);
            }

            public string WeekBirthday()
            {
                return YourBirthday.ToString("dddd");
            }
            public string WeekBirthdayWill(int year)
            {
                DateTime YourBirthday1 = new DateTime(year, YourBirthday.Month, YourBirthday.Day);
                return YourBirthday1.ToString("dddd");
            }
            public TimeSpan CountDays()
            {
                return DateTime.Today.Subtract(YourBirthday);
            }
        }


        static void Main(string[] args)
        {
            Fraction fractionA = new Fraction(3, 34);
            Fraction fractionB = new Fraction(5, 16);

            Console.WriteLine(fractionA.Addition(fractionB));
            Console.WriteLine(fractionA.Subtraction(fractionB));
            Console.WriteLine(fractionA.Multiplication(fractionB));
            Console.WriteLine(fractionA.Division(fractionB));

            Console.WriteLine();

            ComplexNumbers complexA = new ComplexNumbers(5, 14);
            ComplexNumbers complexB = new ComplexNumbers(23, 9);

            Console.WriteLine(complexA.Addition(complexB));
            Console.WriteLine(complexA.Subtraction(complexB));
            Console.WriteLine(complexA.Division(complexB));
            Console.WriteLine(complexA.Multiplication(complexB));

            Birthday birthday = new Birthday(12, 12, 2001);
            Console.WriteLine(birthday.WeekBirthday());

            Console.WriteLine(birthday.WeekBirthdayWill(2022));

            Console.WriteLine(birthday.CountDays());

        }
    }
}
