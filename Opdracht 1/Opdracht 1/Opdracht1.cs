using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Opdracht_1
{
    internal class Opdracht1
    {
        public static void opdracht1()
        {
            Console.WriteLine("Opdracht 1: Som van 2 getallen:");
            Console.WriteLine("Geef getal 1:");
            string getal1 = Console.ReadLine();
            Console.WriteLine("Geef getal 1:");
            string getal2 = Console.ReadLine();

            int g1 = int.Parse(getal1);
            int g2 = int.Parse(getal2);
            int g3 = (g1 + g2);
            Console.WriteLine($"De som van: {g1} + {g2} = {g3}");
            Console.WriteLine($"De uitkomst is: {g3}");
        }
        public static void opdracht2(){
            Console.WriteLine("Opdracht 2: alle getallen tussen getal1 en getal2 optellen:");
            Console.WriteLine("Geef getal 1:");
            string getal1 = Console.ReadLine();
            Console.WriteLine("Geef getal 2:");
            string getal2 = Console.ReadLine();

            int g1 = int.Parse(getal1);
            int g2 = int.Parse(getal2);
            int uit = 0;

            for (int i = g1; i <= g2; i++)
            {
                uit += i;
            }

            Console.WriteLine($"Het antwoord is: {uit}");
        }
        public static void opdracht3()
        {
            Console.WriteLine("Opdracht 3: Som van 2 getallen:");
            Console.WriteLine("Geef getal 1:");
            string getal1 = Console.ReadLine();
            Console.WriteLine("Geef getal 2:");
            string getal2 = Console.ReadLine();

            int g1 = int.Parse(getal1);
            int g2 = int.Parse(getal2);
            int uit = 0;
            int aantal = 0;
            List<int> termsList = new List<int>();
            for (int i = g1; i < g2; i+=3)
            {
                aantal++;
                uit += i;
                termsList.Add(i);
            }
            double gem = termsList.Average();
            Console.WriteLine($"Het totaal is: {uit}, aantal getallen is: {aantal}");
            Console.WriteLine($"Het gemiddelde is: {gem}");
        }
        public static void opdracht4()
        {
            Console.WriteLine("Dit programma berekend het gemiddelde van een aantal rapportcijfers.");
            List<int> cijfers = new List<int>();
            var cijfer = 0;
            do
            {
                Console.WriteLine("Voer een cijfer in (0 is stoppen)");
                cijfer = int.Parse(Console.ReadLine());
                if (cijfer != 0 && cijfer <= 10 && cijfer >= 1)
                {
                    cijfers.Add(cijfer);
                }
                else if (cijfer > 10){ Console.WriteLine("Het cijfer mag niet groter dan 10 zijn."); }
                else if (cijfer < 0) { Console.WriteLine("Het cijfer mag niet kleiner dan 1 zijn."); }
            }while(cijfer != 0);
            Console.WriteLine($"Het totaal is: {cijfers.Sum()}, aantal cijfers: {cijfers.Count()}");
            Console.WriteLine($"Het gemiddelde is: {Math.Round(cijfers.Average(),1)}");
            Console.WriteLine($"Het hoogste cijfer is: {cijfers.Max()}");
        }
        public static void opdracht5()
        {
            Console.WriteLine("Dit programma vertel hoeveel van de ingevoerde getallen kleiner  of gelijk zijn aan 250.");
            var totaal = 0;
            var getal = 0;
            do
            {
                Console.WriteLine("Voer een getal in (9999 is stoppen)");
                getal = int.Parse(Console.ReadLine());
                if (getal <= 250)
                {
                    totaal++;
                }
            } while (getal != 9999);
            Console.WriteLine($"Het aantal getallen onder of gelijk aan 250 zijn: {totaal}");
        }
        public static void opdracht6()
        {
            Console.WriteLine("Dit programma bepaald of een leerling overgaat.");
            List<double> cijfers = new List<double>();
            double cijfer = 0;
            var onvoldoendes = 0;
            do
            {
                Console.WriteLine("Voer een cijfer in (0 is stoppen)");
                cijfer = double.Parse(Console.ReadLine());
                if (cijfer != 0 && cijfer <= 10 && cijfer >= 1)
                {
                    cijfers.Add(cijfer);
                    if (cijfer <= 5)
                    {
                        onvoldoendes++;
                    }
                }
                else if (cijfer > 10) { Console.WriteLine("Het cijfer mag niet groter dan 10 zijn."); }
                else if (cijfer < 0) { Console.WriteLine("Het cijfer mag niet kleiner dan 1 zijn."); }
            } while (cijfer != 0);
            Console.WriteLine($"Het totaal is: {cijfers.Sum()}, aantal cijfers: {cijfers.Count()}");
            Console.WriteLine($"Het gemiddelde is: {Math.Round(cijfers.Average(), 2)}");
            Console.WriteLine($"Het aantal onvoldoendes is: {onvoldoendes}");
            if(onvoldoendes<5 && cijfers.Average() >= 6.1)
            {
                Console.WriteLine($"Leerling gaat over");
            }
            else { Console.WriteLine("Leerling blijft zitten"); }
            Console.WriteLine("");
        }
        public static void opdracht7()
        {
            Console.WriteLine("Dit programma geeft aan hoeveel er van elke letter in de ingevulde zin zit.");
            string str = Console.ReadLine();
            str.ToLower();
            int[] num = new int[26];
            char a = 'a';
            int i = 0, j = 0, x = 0;
            do
            {
                num[i] = str.Length - str.Replace($"{(char)(a + i)}", "").Length;
                i++;
                if (num[j] != 0)
                {
                    Console.WriteLine($"aantal {(char)(a + i)} is: {num[i]}");
                    x++;
                }
            } while (i != 26);
            do
            {
                if (num[j] != 0)
                {
                    Console.WriteLine($"aantal {(char)(a + j)} is: {num[j]}");
                    x++;
                }
                j++;
            }while(j != 26);
            if(x != 26)
            {
                Console.WriteLine("De rest zit er niet in.");
            }
        }
        public static void opdracht8()
        {
            Console.WriteLine("Dit programma draait de ingevoerde zin om.");
            string str = Console.ReadLine();
            var rev = str.ToCharArray();
            int i = str.Length-1;
            double untill = str.Length - 1;
            char temp;
            for (int j = 0; j < Math.Ceiling(untill / 2);)
            {
                temp = rev[j];
                rev[j] = rev[i-j];
                rev[i-j] = temp;
                j++;
            }
            Console.WriteLine(rev);
        }
        public static void opdracht9()
        {
            Console.WriteLine("Dit programma deelt een gebroken getal op in een heel deel en een decimaal deel.");
            double inv;
            do
            {
            Console.WriteLine("Voer een getal in. 0 om te stoppen");
            string str = Console.ReadLine();
            inv = double.Parse(str);
            var i = Math.Floor(inv);
            var j = inv - i;
            Console.WriteLine($"hel gehele deel is:{i}");
            Console.WriteLine($"hel decimale deel is:{j}");
            } while (inv != 0);
        }
        public static void opdracht10()
        {
            Console.WriteLine("Dit programma kijkt of een bankrekeningnummer klopt of niet.");
            int inv = 1;
            do
            {
                Console.WriteLine("Voer een bankrekeningnummer in: (0 is stoppen)");
                inv = int.Parse(Console.ReadLine());
                int[] digits = NumberToIntArray(inv);
                int length = digits.Length;
                if (length == 9)
                {
                    for (var i = 0; i < 9;)
                    {
                        digits[i] *= (length - i);
                        i++;
                    }
                    int total = digits.Sum();
                    int rest = total % 11;
                    if (rest == 0)
                    {
                        Console.WriteLine("corrrect bankrekeningnummer.");
                    }
                    else
                    {
                        Console.WriteLine("incorrrect bankrekeningnummer.");
                    }
                }
                else if (inv != 0)
                {
                    Console.WriteLine("Het moeten 9 getallen zijn");
                }
            } while (inv != 0);
        }
        public static void opdracht11()
        {
            Console.WriteLine("Dit programma kijkt of een ingevoerd getal een priemgetal is.");
            int priem = 1;
            do {
                Console.WriteLine("Voer een getal in: (0 is stoppen)");
                int a = 0;
                priem = int.Parse(Console.ReadLine());
                double boundry = Math.Floor(Math.Sqrt(priem));
                Console.WriteLine(boundry);
                for (int i = 1; i <= boundry; i++)
                {
                    if (priem % i == 0)
                    {
                        a++;
                    }
                }
                if(priem != 0)
                {
                    if (a == 1)
                    {
                        Console.WriteLine($"{priem} is een priemgetal");
                    }
                    else
                    {
                        Console.WriteLine($"{priem} is geen priemgetal");
                    }
                }
            } while (priem!=0);
        }
        public static void opdracht12()
        {
            Console.WriteLine("Deze opdracht is nog niet gemaakt.");
        }
        public static void opdracht13()
        {
            Console.WriteLine("Deze opdracht is nog niet gemaakt.");
        }
        public static int[] NumberToIntArray(int num)
        {
            if (num == 0)
                return new int[1] { 0 };

            List<int> digits = new List<int>();

            for (; num != 0; num /= 10)
                digits.Add(num % 10);

            int[] array = digits.ToArray();
            System.Array.Reverse(array);

            return array;
        }

        static void Main()
        {
            string eind = "";
            do
            {
                Console.WriteLine("opdracht:");
                String opdracht = Console.ReadLine();
                int op = int.Parse(opdracht);
                do {
                    Boolean def = false;
                    switch (op)
                    {
                        case 1:
                            opdracht1();
                            break;

                        case 2:
                            opdracht2();
                            break;

                        case 3:
                            opdracht3();
                            break;

                        case 4:
                            opdracht4();
                            break;

                        case 5:
                            opdracht5();
                            break;

                        case 6:
                            opdracht6();
                            break;

                        case 7:
                            opdracht7();
                            break;

                        case 8:
                            opdracht8();
                            break;

                        case 9:
                            opdracht9();
                            break;

                        case 10:
                            opdracht10();
                            break;

                        case 11:
                            opdracht11();
                            break;

                        case 12:
                            opdracht12();
                            break;

                        case 13:
                            opdracht13();
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Die opdracht bestaat niet.");
                            eind = "terug";
                            def = true;
                            break;
                    }
                    if (def != true)
                    {
                        Console.WriteLine("typ exit om het programma uit te gaan, terug om naar de opdrachten te gaan, of iets anders om de opdracht nog eens te doen");
                        eind = Console.ReadLine();
                        Console.Clear();
                    }
                } while (eind != "terug" && eind != "exit");

            } while (eind != "exit");
            
        }
    }
}
