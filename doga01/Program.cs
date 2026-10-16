using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace doga01
{
    internal class Program
    {

        static void Menukiir()
        {
            Console.WriteLine("===PETRIK KALANDPARK");
            Console.WriteLine("1.) Napijegy vásárlás");
            Console.WriteLine("2.) Pálya választása");
            Console.WriteLine("3.) Kupon választása");
            Console.WriteLine("4.) Napi bevétel");
            Console.WriteLine("5.) Kilépés Választás");
        }
        static string Jegytipus(int age)
        {
            if (age < 7)
            {
                return "Mini jegy";
            }
            else if (age < 15)
            {
                return "Junior jegy";
            }
            else if (age < 24)
            {
                return "Ifjúsági jegy";
            }
            else if (age < 59)
            {
                return "Felnőtt jegy";
            }
            else
            {
                return "Senior jegy";
            }
        }
        static int Jegyar(int age)
        {
            if (age < 7)
            {
                return 1000;
            }
            else if (age < 15)
            {
                return 2200;
            }
            else if (age < 24)
            {
                return 3000;
            }
            else if (age < 59)
            {
                return 4500;
            }
            else
            {
                return 2800;
            }
        }

        static int Napijegy(int bevetel)
        {
            Console.Clear();
            Console.Write("Add meg a nevedet: ");
            string nev = Console.ReadLine();
            Console.Write("Add meg az életkorodat: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Szia {nev}, életkorod: {age}");
            if (age < 0 || age > 120)
            {
                Console.WriteLine("Érvénytelen életkor");
                Console.ReadLine();
                return 0;
            }
            else
            {
                Console.WriteLine($"A jegyed tipusa: {Jegytipus(age)} melynek ára: {Jegyar(age)}");
                bevetel += Jegyar(age);
                Console.ReadLine();
                return Jegyar(age);

            }
        }

        static void Palyavalasztas()
        {
            Console.Clear();
            Console.WriteLine("=== KALANDPÁLYÁK ===");
            Console.WriteLine("1.) Gyerekpálya");
            Console.WriteLine("2.) Erdei pálya");
            Console.WriteLine("3.) Extrém pálya");
            Console.Write("Melyik pályán szeretnél menni: ");
            int valaszadas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg a magasságod: ");
            int magassag = Convert.ToInt32(Console.ReadLine());
            switch (valaszadas)
            {
                case 1:
                    if (magassag >= 90)
                    {
                        Console.WriteLine("Magasságod megfelel mehetsz a pályán."); break;
                    }
                    else
                    {
                        Console.WriteLine("Sajnáljuk de magasságod nem felel meg ehhez a páylához"); break;
                    }
                case 2:
                    if (magassag >= 130)
                    {
                        Console.WriteLine("Magasságod megfelel mehetsz a pályán."); break;
                    }
                    else
                    {
                        Console.WriteLine("Sajnáljuk de magasságod nem felel meg ehhez a páylához"); break;
                    }
                case 3:
                    if (magassag >= 160)
                    {
                        Console.WriteLine("Magasságod megfelel mehetsz a pályán."); break;
                    }
                    else
                    {
                        Console.WriteLine("Sajnáljuk de magasságod nem felel meg ehhez a páylához"); break;
                    }
            }
        }
        static double Kuponosar(int choice, int origin)
        {
            double ujar = origin;
            switch (choice)
            {

                case 1:
                    return ujar;

                case 2:
                    ujar = origin * 0.90;
                    return ujar;
                case 3:
                    ujar = origin * 0.75;
                    return ujar;
                default:
                    return ujar;
            }
        }
        static void Kuponcalc()
        {
            Console.Write("Add meg az eredeti árat: ");
            int origin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.) Nincs kupon");
            Console.WriteLine("2.) SILVER kupon -10%");
            Console.WriteLine("3.) GOLD kupon -25%");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice > 0 && choice <= 3)
            {
                Console.WriteLine($"A kiválasztott kuponnal az új ár:{Kuponosar(choice, origin)}Ft");
            }
            else
            {
                Console.WriteLine("Helytelen választás nincs kupon!!!");
            }

        }
        static void Napibevetel(int bevetel)
        {
            Console.WriteLine($"A mai napi bevétel összesen: {bevetel}Ft");
        }



        static void Main(string[] args)
        {
            int valasztas = 0;
            int bevetel = 0;
            bool fut = true;

            do
            {
                try
                {

                    Console.Clear();
                    Menukiir();

                    valasztas = Convert.ToInt32(Console.ReadLine());
                    switch (valasztas)
                    {
                        case 1:
                            bevetel += Napijegy(bevetel);
                            break;

                        case 2:
                            Palyavalasztas();
                            Console.ReadLine();
                            break;

                        case 3:
                            Console.Clear();
                            Kuponcalc();
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Napibevetel(bevetel);
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Viszlát program bezárul");
                            fut = false;
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Érvénytelen választás válassz újra.");
                            break;
                    }
                }

                catch (Exception)
                {

                    Console.WriteLine("Hibás értéket adtál meg!");
                    Console.ReadLine();

                }




                } while (fut);
            }

            }
        }

            
            
        
        
    

