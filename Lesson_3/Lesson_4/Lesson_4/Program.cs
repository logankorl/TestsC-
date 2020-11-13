using System;

class Program
{

    static void Main()
    {
        //ComplexExample();
        Sum();

        Console.ReadKey();
    }

    private static void ComplexExample()
    {
        Complex complex = new Complex();
        complex.im = 4;
        complex.re = 4;

        Complex complex2 = new Complex();
        complex2.im = 2;
        complex2.re = 2;
        Console.WriteLine(complex.Plus(complex2).ToString());
        Console.WriteLine(complex.Minus(complex2).ToString());
        Console.WriteLine(complex.Multiply(complex2).ToMultyply());
    }


    class Complex
    {
        public double im;
        public double re;
        public double pr;
        public Complex Plus(Complex x2)
        {
            Complex result = new Complex();

            result.im = x2.im + im;
            result.re = x2.re + re;

            return result;
        }

        public Complex Minus(Complex x2)
        {
            Complex result = new Complex();
            result.im = x2.im - im;
            result.re = x2.re - re;
            return result;
        }

        public Complex Multiply(Complex x2)
        {
            Complex result = new Complex();
            result.im = x2.im - im;
            result.re = x2.re - re;
            result.pr = (x2.re*re - x2.im*im) + (x2.re * im + x2.re * im);

            return result;
        }

        public string ToMultyply()
        {
            return pr + "i";
        }

        new public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    public static void Sum()
    {
        try
        {
            int number = 0;
            int num = 0;
            Console.WriteLine("Enter the numbers by a spaces");
            do
            {
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 != 0)
                {
                    number += num;
                }
            }

            while (num != 0);

            string sum_s = number.ToString();
            Int32.TryParse(sum_s, out number);
            Console.WriteLine(number);

        }
        catch
        {
            Console.WriteLine("Возникло исключение!");
            Sum();
        }
        
    }
}
