using System;

namespace LabExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            while (true)
            {
                try
                {
                    Console.Write("Enter first number: ");
                    if (!(double.TryParse(Console.ReadLine(), out double a)))
                    {
                        Console.WriteLine("Please enter a numnber!");
                        goto Start;
                    }

                    Console.Write("Enter operator (+ - * /): ");
                    if (!(char.TryParse(Console.ReadLine(), out char c)))
                    {
                        Console.WriteLine("Please enter correct operator: + - * / ");
                        goto Start;
                    }
                    else if (!(c == '+' || c == '-' || c == '*' || c == '/'))
                    {
                        Console.WriteLine("Please enter correct operator: + - * / ");
                        goto Start;
                    }

                    Console.Write("Enter second number: ");
                    if (!(double.TryParse(Console.ReadLine(), out double b)))
                    {
                        Console.WriteLine("Please enter a numnber!");
                        goto Start;
                    }

                    if (c == '+')
                    {
                        Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " + (a + b));
                    }
                    else if (c == '-')
                    {
                        Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " + (a - b));
                    }
                    else if (c == '*')
                    {
                        Console.WriteLine(a.ToString() + " * " + b.ToString() + " = " + a * b);
                    }
                    else if (c == '/')
                    {
                        // avoid divide-by-zero error
                        if (b == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        Console.WriteLine(a.ToString() + " / " + b.ToString() + " = " + (Math.Round((a / b), 2)).ToString());
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected error: " + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Calculation attempt finished.");
                    Console.WriteLine("-------------------------");
                }
            }
        }
    }
}