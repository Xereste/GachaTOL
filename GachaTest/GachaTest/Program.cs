using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GachaTest
{
    class Program
    {

        #region DECLARATION

        static int count = 0; // total of summons
        static bool first = false; // for first summon
        static int heroes_stone = 0;
        static int value1 = 0; // total of summoned 3 stars
        static int value2 = 0; // total of summoned 4 stars
        static int value3 = 0; // total of summoned 5 stars
        static int valuefeatured2 = 0; // total of summoned featured 4 stars
        static int valuefeatured3 = 0; // total of summoned featured 5 stars

        #endregion

        #region METHOD

        // Display some informations
        static void DisplayMe()
        {
            float sum = (float)value1 + (float)value2 + (float)value3;
            float res1 = (float)value1 * 100 / sum;
            float res2 = (float)value2 * 100 / sum;
            float res3 = (float)value3 * 100 / sum;
            float sumFeatured = (float)valuefeatured2 + (float)valuefeatured3;
            float resFeatured2 = (float)valuefeatured2 * 100 / sumFeatured;
            float resFeatured3 = (float)valuefeatured3 * 100 / sumFeatured;
            if (sum == 1 || sum == 0)
            {
                Console.WriteLine(count + " summon / " + sum + " hero summoned / " + heroes_stone + " stones wasted (ahem used).");
            }
            else
            {
                Console.WriteLine(count + " summons / " + sum + " heros summoned / " + heroes_stone + " stones wasted (ahem used).");
            }
            Console.WriteLine("Rate 1: " + res1 + "% (" + value1 + "/" + sum + ").");
            Console.WriteLine("Rate 2: " + res2 + "% (" + value2 + "/" + sum + ").");
            Console.Write("Rate 3: " + res3 + "% (" + value3 + "/" + sum + ").");
            if(valuefeatured2 != 0 || valuefeatured3 != 0)
            {
                Console.WriteLine("\nRate Featured 2: " + resFeatured2 + "% (" + valuefeatured2 + "/" + sumFeatured + ").");
                Console.Write("Rate Featured 3: " + resFeatured3 + "% (" + valuefeatured3 + "/" + sumFeatured + ").");
            }
        }

        // Compute rarity summoned
        static void ComputeMe(int value)
        {
            switch (value)
            {
                case 1:
                    value1++;
                    break;
                case 2:
                    value2++;
                    break;
                case 3:
                    value3++;
                    break;
                case 4:
                    valuefeatured2++;
                    break;
                case 5:
                    valuefeatured3++;
                    break;
                default:
                    break;
            }
        }

        // Display rate for each summon on modified summon
        static void DisplayModified(List<int> list)
        {
            int tmp1 = 0;
            int tmp2 = 0;
            int tmp3 = 0;
            for (int i = 0; i < gacha.i; i++)
            {
                if (list.ElementAt(i) == 1)
                {
                    tmp1++;
                }
                if (list.ElementAt(i) == 2)
                {
                    tmp2++;
                }
                if (list.ElementAt(i) == 3)
                {
                    tmp3++;
                }
            }
            Console.WriteLine("Rate for \"1\" on this batch was: " + tmp1 + "%.");
            Console.WriteLine("Rate for \"2\" on this batch was: " + tmp2 + "%.");
            Console.WriteLine("Rate for \"3\" on this batch was: " + tmp3 + "%.");
        }
        
        // Introduction, initilization of GachaBox
        static void GachaText()
        {
            int tmp1 = 0;
            int tmp2 = 0;
            int tmp3 = 0;
            List<int> carote = gacha.SubGachaBox();
            if (gacha.BalancedPlease(gacha.rate1, gacha.rate2, gacha.rate3))
            {
                gacha.FillSubGacha(carote, gacha.rate1, gacha.rate2, gacha.rate3);
                gacha.Shuffle(carote);
                for (int i = 0; i < gacha.i; i++)
                {
                    //Console.WriteLine("| " + carote.ElementAt(i) + " |");
                    if (carote.ElementAt(i) == 1)
                    {
                        tmp1++;
                    }
                    if (carote.ElementAt(i) == 2)
                    {
                        tmp2++;
                    }
                    if (carote.ElementAt(i) == 3)
                    {
                        tmp3++;
                    }
                }
                Console.WriteLine("\"1\" = 3* for ToLink");
                Console.WriteLine("\"2\" = 4* for ToLink");
                Console.WriteLine("\"3\" = 5* for ToLink\n");
                Console.WriteLine("Rate for \"1\" on this batch is: " + tmp1 + "%.");
                Console.WriteLine("Rate for \"2\" on this batch is: " + tmp2 + "%.");
                Console.WriteLine("Rate for \"3\" on this batch is: " + tmp3 + "%.");
                Tryme(carote);
            }
            else
            {
                Console.WriteLine("Well, your dev is so bad.");
            }
        }

        // Solo summon
        static void GachaPlay(List<int> list)
        {
            if(!first)
            {
                FourStarsOrMore(true);
                first = !first;
            }
            else
            {
                int random = gacha.random.Next(gacha.i);
                Console.WriteLine("You will have : " + list.ElementAt(random) + "!\n");
                ComputeMe(list.ElementAt(random));
            }
            DisplayMe();
            Tryme(list);
        }

        // Featured summon
        static void Featured(bool test)
        {
            gacha.CheatOrNot(test);
            List<int> featured = gacha.SubGachaBox();
            if (gacha.BalancedPlease(gacha.rateFeatured2, gacha.rateFeatured3, 0))
            {
                gacha.FillFeatured(featured, gacha.rateFeatured2, gacha.rateFeatured3);
                gacha.Shuffle(featured);
            }
            int random = gacha.random.Next(gacha.i);
            Console.WriteLine("Featured: " + featured.ElementAt(random) + "!\n");
            if(featured.ElementAt(random) == 2)
            {
                ComputeMe(4);
            }
            else
            {
                ComputeMe(5);
            }
        }

        // Featured summon
        static void FourStarsOrMore(bool test)
        {
            gacha.CheatOrNot(test);
            List<int> FourStarsOrMore = gacha.SubGachaBox();
            if (gacha.BalancedPlease(gacha.rateFeatured2, gacha.rateFeatured3, 0))
            {
                gacha.FillFeatured(FourStarsOrMore, gacha.rateFeatured2, gacha.rateFeatured3);
                gacha.Shuffle(FourStarsOrMore);
            }
            int random = gacha.random.Next(gacha.i);
            Console.WriteLine("2 or 3: " + FourStarsOrMore.ElementAt(random) + "!");
            ComputeMe(FourStarsOrMore.ElementAt(random));
        }

        // Multi summon with a new list for each summon (include featured if used)
        static void MultiTruque(List<int> list, int nb, bool displayrate, bool featured, bool cheat)
        {
            int tmp = 0;
            int test = tmp + 1;
            while (tmp != nb)
            {
                List<int> carote2 = gacha.SubGachaBox();
                if (gacha.BalancedPlease(gacha.rate1, gacha.rate2, gacha.rate3))
                {
                    gacha.FillSubGacha(carote2, gacha.rate1, gacha.rate2, gacha.rate3);
                    gacha.Shuffle(carote2);
                }
                int random = gacha.random.Next(gacha.i);
                Console.Write("Summon number " + test + ": " + carote2.ElementAt(random) + "!\n");
                if(displayrate)
                {
                    DisplayModified(carote2);
                }
                ComputeMe(carote2.ElementAt(random));
                tmp++;
                test++;
            }
            while (tmp != nb+2)
            {
                FourStarsOrMore(true);
                tmp++;
            }
            if (featured)
            {
                Featured(cheat);
            }
            DisplayMe();
            Tryme(list);
        }

        // Multi summon with the same list for each summon (include featured if used)
        static void MultiNormal(List<int> list, int nb, bool featured, bool cheat)
        {
            int tmp = 0;
            while(tmp != nb)
            {
                int test = tmp + 1;
                int random = gacha.random.Next(gacha.i);
                Console.Write("Summon number " + test + ": " + list.ElementAt(random) + "!\n");
                ComputeMe(list.ElementAt(random));
                tmp++;
            }
            while(tmp != nb+2)
            {
                FourStarsOrMore(true);
                tmp++;
            }
            if(featured)
            {
                Featured(cheat);
            }
            DisplayMe();
            Tryme(list);
        }

        // Try again~
        static void Tryme(List<int> list)
        {
            Console.WriteLine("\n\nWrite \"1\" for 1 summon (1st = \"2\" or more!)");
            Console.WriteLine("\"2\" for 10 summons (2x \"2\" or more!)");
            Console.WriteLine("\"3\" for 10 modified summons (2x \"2\" or more!)");
            Console.WriteLine("\"4\" for 10 summons + 1 featured (2x \"2\" or more!)");
            Console.WriteLine("\"5\" for 10 summons + 1 modified featured (2x \"2\" or more!)");
            Console.WriteLine("\"6\" for 10 modified summons + 1 featured (2x \"2\" or more!)");
            Console.WriteLine("\"7\" for 10 modified summons + 1 modified featured (2x \"2\" or more!)");
            Console.WriteLine("Otherwise \"8\"\n");
            try
            {
                int read = Convert.ToInt32(Console.ReadLine());
                if (read == 1)
                {
                    Console.Write("\n");
                    count++;
                    heroes_stone += 5;
                    GachaPlay(list);
                }
                else if (read == 2)
                {
                    Console.Write("\n");
                    count++;
                    heroes_stone += 50;
                    MultiNormal(list, 8, false, false);
                }
                else if (read == 3)
                {
                    Console.Write("\n");
                    count++;
                    heroes_stone += 50;
                    MultiTruque(list, 8, false, false, false);
                }
                else if (read == 4)
                {
                    Console.Write("\n");
                    count++;
                    heroes_stone += 50;
                    MultiNormal(list, 8, true, false);
                }
                else if (read == 5)
                {
                    Console.Write("\n");
                    count++;
                    heroes_stone += 50;
                    MultiNormal(list, 8, true, true);
                }
                else if (read == 6)
                {
                    Console.Write("\n");
                    count++;
                    heroes_stone += 50;
                    MultiTruque(list, 8, false, true, false);
                }
                else if (read == 7)
                {
                    Console.Write("\n");
                    count++;
                    heroes_stone += 50;
                    MultiTruque(list, 8, false, true, true);
                }
                else if (read == 8)
                {
                    Console.WriteLine("\nGoodbye!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You need to learn to write, thank you.");
                    Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("You need to learn to write, thank you.");
                Console.ReadLine();
            }
        }

        #endregion

        #region MAIN

        // Dat main
        static void Main(string[] args)
        {
            GachaText();
        }

        #endregion

    }
}