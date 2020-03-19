using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_vol2
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal plus;
            decimal minus;
            decimal mnozenie;
            decimal dzielenie;


            decimal result;

        poczatek:
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("KALKULATOR DZIAŁAŃ");
                Console.WriteLine("");
                Console.ResetColor();

                Console.Write("Wpisz liczbę:  ");
                decimal a = Convert.ToDecimal(Console.ReadLine());


                Console.Write("Wybierz ( +, -, *, / ):  ");
                string z1 = Console.ReadLine();

                Console.Write("Wpisz kolejną liczbę:  ");
                decimal b = Convert.ToDecimal(Console.ReadLine());


                Console.Write("Wybierz ( +, -, *, / ) lub znak ( = ):  ");
                string z2 = Console.ReadLine();

               

                if (z1 == "+" && z2 == "=")
                {

                    plus = a + b;

                    Console.WriteLine("Wynik to:  " + plus);
                    Console.ReadKey();
                    Console.Clear();
                    goto poczatek;
                }



                if (z1 == "-" && z2 == "=")
                {
                    minus = a - b;

                    Console.WriteLine("Wynik to:  " + minus);
                    Console.ReadKey();
                    Console.Clear();
                    goto poczatek;
                }



                if (z1 == "*" && z2 == "=")
                {
                    mnozenie = a * b;

                    Console.WriteLine("Wynik to:  " + mnozenie);
                    Console.ReadKey();
                    Console.Clear();
                    goto poczatek;
                }



                if (z1 == "/" && z2 == "=")
                {
                    dzielenie = a / b;

                    Console.WriteLine("Wynik to:  " + dzielenie);
                    Console.ReadKey();
                    Console.Clear();
                    goto poczatek;

                }

               

                else
                {



                    Console.Write("Wpisz ostatnią liczbę:  ");
                    decimal c = Convert.ToDecimal(Console.ReadLine());



                    //działanie po dodawaniu

                    if (z1 == "+" && z2 == "+")
                    {

                        result = a + b + c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "+" && z2 == "-")
                    {
                        result = a + b - c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "+" && z2 == "*")
                    {
                        result = a + b * c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "+" && z2 == "/")
                    {
                        result = a + b / c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;

                    }


                    //działanie po odejmowaniu


                    if (z1 == "-" && z2 == "+")
                    {

                        result = a - b + c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "-" && z2 == "-")
                    {
                        result = a - b - c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "-" && z2 == "*")
                    {
                        result = a - b * c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "-" && z2 == "/")
                    {
                        result = a - b / c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;

                    }




                    //działanie po mnożeniu

                    if (z1 == "*" && z2 == "+")
                    {

                        result = a * b + c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "*" && z2 == "-")
                    {
                        result = a * b - c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "*" && z2 == "*")
                    {
                        result = a * b * c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "*" && z2 == "/")
                    {
                        result = a * b / c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }




                    //działanie po dzieleniu

                    if (z1 == "/" && z2 == "+")
                    {

                        result = a / b + c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "/" && z2 == "-")
                    {
                        result = a / b - c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "/" && z2 == "*")
                    {
                        result = a / b * c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;
                    }



                    if (z1 == "/" && z2 == "/")
                    {
                        result = a / b / c;

                        Console.WriteLine("Wynik to:  " + result);
                        Console.ReadKey();
                        Console.Clear();
                        goto poczatek;

                    }


                }


            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("Wprowadź poprawny znak"); ; ;
                Console.ReadKey();
                Console.Clear();
                goto poczatek;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Brak możliwości dzielenia przez zero"); ; ;
                Console.ReadKey();
                Console.Clear();
                goto poczatek;
            }
            catch (Exception)
            {

                Console.WriteLine("Wprowadź poprawny znak"); ; ;
                Console.ReadKey();
                Console.Clear();
                goto poczatek;
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}
