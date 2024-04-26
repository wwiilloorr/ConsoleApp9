using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp9
{
    internal class Program
    {
        public static void showError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Errorrrrrrrr!!!!!!!!!!");
            Console.ResetColor();
        }
        public static void mainWork()
        {
            int PlaerMoney = 0;
            int CountfoMylo = 0;
            int CountofZubnaPasta = 0;
            int CountofSampoo = 0;

            while (true) //EXIIITTT if player type 4 he laeves fron program(for sasha)
            {
               
                Console.WriteLine("--= Witamy do nascego magazynu!! =--");//Avaible products
                Console.WriteLine("Mylo - 34 po 12 zlotyh - 1");
                Console.WriteLine("Zubna Pasta - 56 po 52 zlotyh - 2");
                Console.WriteLine("Shampoo - 12 po 70 zlotyh - 3");
                Console.WriteLine("_EXIT!!!!!!!_  - 4");//EXIIITTT if player type 4 he laeves fron program

                Console.WriteLine("Ile mash zlotyh?");  //Count of money 
                PlaerMoney = Convert.ToInt32(Console.ReadLine());

                int chooseF = Convert.ToInt32(Console.ReadLine());

                if (chooseF == 1)//Mylo
                {
                    Console.WriteLine("How many of mylo do you want?");
                    CountfoMylo = Convert.ToInt32(Console.ReadLine());
                    if (CountfoMylo * 12 > PlaerMoney)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error!You raise your limit of money!");//Якщо користувач потратить всі гроші саме на цьому продукту
                        Console.ResetColor();
                    }
                    else if (CountfoMylo <= 0 && CountfoMylo >= 34)
                    {
                        showError();
                    }
                    else if (CountfoMylo >= 0 && CountfoMylo <= 34)
                    {
                        Console.WriteLine("You just choosed" + CountfoMylo + "Mylo");
                        CountfoMylo *= 12;

                        Console.WriteLine("You just buyed: " + CountfoMylo + "Mylo");
                        Console.WriteLine("You already have: " + PlaerMoney + "Zlotyh");
                    }

                    else if (PlaerMoney >= 0 && CountfoMylo * 12 < PlaerMoney)
                    {
                        PlaerMoney -= CountfoMylo * 12;
                        Console.WriteLine("You already have: " + PlaerMoney + "Zlotyh");//Віднімання від грошей користувача гроші за мило
                    }
                    else
                    {
                        showError();
                    }

                }
                else if (chooseF == 2)//ZubnaPasta
                {
                    Console.WriteLine("How many of Zubna Pasts do you want?");
                    CountofZubnaPasta = Convert.ToInt32(Console.ReadLine());
                    if (CountofZubnaPasta * 54 > PlaerMoney)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error!You raise your limit of money!");//Якщо користувач потратить всі гроші саме на цьому продукту
                        Console.ResetColor();
                    }
                    else if (CountofZubnaPasta <= 0 && CountofZubnaPasta >= 56)
                    {
                        showError();
                    }
                    else if (CountofZubnaPasta >= 0 && CountofZubnaPasta <= 56)
                    {
                        Console.WriteLine("You just choosed" + CountofZubnaPasta + "Zubna Pasta!!");
                        CountfoMylo *= 54;
                        Console.WriteLine("You just get" + CountofZubnaPasta + "Зубна Паста!!");

                    }
                    else if (PlaerMoney >= 0 && CountofZubnaPasta * 54 < PlaerMoney)
                    {
                        PlaerMoney -= CountofZubnaPasta * 54;//Віднімання від грошей користувача гроші за зубну пасту
                        Console.WriteLine("You already have: " + PlaerMoney + "Zlotyh");
                    }

                    else
                    {
                        showError();
                    }
                }
                else if (chooseF == 3)//Shampooo
                {
                    Console.WriteLine("How many of Shampoo do you want?");
                    CountofSampoo = Convert.ToInt32(Console.ReadLine());
                    if (CountofSampoo * 70 > PlaerMoney)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error!You raise your limit of money!");//Якщо користувач потратить всі гроші саме на цьому продукту
                        Console.ResetColor();
                    }
                    else if (CountofSampoo <= 0 && CountofSampoo >= 70)
                    {
                        showError();
                    }
                    else if (CountofSampoo >= 0 && CountofSampoo <= 12)
                    {
                        Console.WriteLine("You just choosed" + CountofSampoo + "Shampoo");
                        CountfoMylo *= 70;

                        Console.WriteLine("You just get" + CountofSampoo + "Shampoo");

                    }

                    else if (PlaerMoney >= 0 && CountofSampoo * 70 < PlaerMoney)
                    {
                        PlaerMoney -= CountofSampoo * 70;//Віднімання від грошей користувача гроші за шампунь
                        Console.WriteLine("You already have: " + PlaerMoney + "Zlotyh");
                    }
                    else
                    {
                        showError();
                    }
                }
                else if (chooseF == 4)
                {
                    Console.WriteLine("Bye Bye!!");//EXIIITTT if player type 4 he laeves fron program
                    Environment.Exit(0);
                }
                else if ((CountofZubnaPasta + CountfoMylo + CountofSampoo) >= PlaerMoney)//Перевірка чи хватає користувачеві на продукти
                {
                    showError();
                }
                else
                {
                    showError();
                }
            }
        }
        static void Main(string[] args)
        {
            mainWork();
        }
    }           
}
