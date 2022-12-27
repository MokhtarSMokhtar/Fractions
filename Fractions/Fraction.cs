using System;
using System.Numerics;

namespace Fractions
{
    public class Fraction
    {
        public int Numerator { get; set; }

        public int denominator { get; set; }

        public Fraction()
        {
        }
        public Fraction(int _Numerator,int _denominator)
        {
            Numerator = _Numerator;
            denominator = _denominator;
        }
        public void Display()
        {
            Console.Write($" {Numerator}\n {denominator} \n");
        }

        public static Fraction operator +(Fraction F1, Fraction F2)
        {
            Fraction result = new Fraction();
            if ( F1.denominator == F2.denominator)
            {
                 result.denominator = F1.denominator;
                 result.Numerator = F1.Numerator + F2.Numerator;
            }
            else
            {
                int Reminder;
                int x;
                int Counter = 1;
                do
                {
                    
                    x = F1.denominator * Counter;

                    Reminder = x % F2.denominator;
                    if (Reminder == 0)
                    {
                        F1.denominator = x;
                        F1.Numerator *= Counter;
                    }
                    Counter++;

                   

                } while (Reminder != 0);


                if (F2.denominator != F1.denominator )
                {
                    int temp = F2.denominator;
                    for (int i = 0; i < x; i++)
                    {
                        F2.denominator = temp * i ;
                        if (F2.denominator == F1.denominator)
                        {
                            F2.Numerator *= i;
                            break;
                        }
                    }
                }
                result.denominator = F1.denominator;
                result.Numerator = F1.Numerator + F2.Numerator;
            }

            return result;
        }

        public static bool operator ==(Fraction F1, Fraction F2)
        {
            return F1.denominator == F2.denominator && F1.Numerator == F2.Numerator;
        }
        public static bool operator !=(Fraction F1, Fraction F2)
        {
            return F1.denominator != F2.denominator && F1.Numerator != F2.Numerator;
        }

        public static Fraction operator ++(Fraction F2)
        {
            return new Fraction (F2.denominator + 1, F2.Numerator + 1);
        }
    }
}

 