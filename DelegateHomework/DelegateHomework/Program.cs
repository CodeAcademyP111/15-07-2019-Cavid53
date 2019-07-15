using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHomework
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Single,Minus,Simple numbers

            //Action<int> findnum = GetMinusAndPlusNumber;
            //{
            //    findnum += GetSimpleNumber;
            //    findnum += GetSingleNumber;
            //};

            //findnum(8);
            #endregion

            //bank
            CapitalBank capital = new CapitalBank(500);
            capital.GetMyMoney += delegate(int i,int n)
            {
                Console.WriteLine("Kartda daxil etdiyiniz qeder pul yoxdur");
            };
            capital.GetMoney(600);
        }

        #region Single,Minus,Simple numbers
        //static void GetMinusAndPlusNumber(int a)
        //{
        //    if (a > 0)
        //    {
        //        Console.WriteLine($"{a} Musbet ededdir");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{a} Menfi ededdir");
        //    }

        //}
        //static void GetSingleNumber(int b)
        //{
        //    if (b % 2 == 0)
        //    {
        //        Console.WriteLine($"{b} cutdur");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{b} tekdir");
        //    }
        //}
        //static void GetSimpleNumber(int n)
        //{
        //    int count = 0;

        //    for (int i = 1; i <= n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    if (count == 2)
        //    {
        //        Console.WriteLine($"{n} ededi sadedir");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{n} ededi murekkebdir");
        //    }
        //}
        #endregion
        
    }
    //bank
    class CapitalBank
    {
        public event Action<int,int> GetMyMoney;
        public int TheMoneyOfKart { get; private set; }

        public CapitalBank(int m)
        {
            TheMoneyOfKart = m; 
        }
        public void GetMoney(int money)
        {
            if (TheMoneyOfKart >= money)
            {
                Console.WriteLine("Buyurun, pulunuzu goturun");
            }
            else
            {
                GetMyMoney?.Invoke(money, TheMoneyOfKart);
            }
        }

      
    }
}
