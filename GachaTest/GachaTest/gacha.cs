using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace GachaTest
{
    class gacha
    {

        #region DECLARATION
        public static Random random = new Random();

        public static float rate1 = 0.64f; // rate for 3 stars
        public static float rate2 = 0.30f; // rate for 4 stars
        public static float rate3 = 0.06f; // rate for 5 stars

        // for testing purpose only
        public static int list1 = 1; // 3 stars
        public static int list2 = 2; // 4 stars
        public static int list3 = 3; // 5 stars
        
        public static int i = 100; // number of elements in a gacha

        public static float rateFeatured3 = 0.06f; // rate for featured 5 stars
        public static float rateFeatured2 = 0.30f; // rate for featured 4 stars
        
        #endregion

        #region METHODS

        // create a list of int where the int represents rarity
        public static List<int> SubGachaBox()
        {
            List<int> subGacha = new List<int>(i);
            return subGacha;
        }

        // fill a list of int with previous given element
        public static void FillSubGacha(List<int> gacha, float rate1, float rate2, float rate3)
        {
            rate1 *= i;
            rate2 *= i;
            rate3 *= i;
            while(rate1 > 0)
            {
                gacha.Add(list1);
                rate1--;
            }
            while(rate2 > 0)
            {
                gacha.Add(list2);
                rate2--;
            }
            while(rate3 > 0)
            {
                gacha.Add(list3);
                rate3--;
            }
        }

        // fill featured list
        public static void FillFeatured(List<int> featured, float rate2, float rate3)
        {
            rate2 *= i;
            rate3 *= i;
            while(rate2 > 0)
            {
                featured.Add(list2);
                rate2--;
            }
            while(rate3 > 0)
            {
                featured.Add(list3);
                rate3--;
            }
        }

        // transform ordonate liste into a real random list
        public static void Shuffle<T>(List<T> list)
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = list.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        // if the featured is 17%-83% or 6%-94%
        public static void CheatOrNot(bool cheat)
        {
            if (cheat)
            {
                rateFeatured2 = 1 - rateFeatured3;
            }
            else
            {
                float sum = rateFeatured2 + rateFeatured3;
                rateFeatured3 /= sum;
                rateFeatured2 /= sum;
            }
        }

        // check if rate gived by user is correct
        public static bool BalancedPlease(float rate1, float rate2, float rate3)
        {
            float total = rate1 + rate2 + rate3;
            if(Convert.ToInt32(total) != 1)
            {
                Console.WriteLine("You fucking bastard, your sum is not equal than 1!");
                Console.ReadLine();
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    #endregion

}
