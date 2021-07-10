using System;

namespace uklon2nd
{
    public class Solution
    {
        public static int MaxPrybutok(int[] prices)
        {
            int res = 0;
            for (int i=0;i<prices.Length;i++)
            {
                for (int j = i+1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > res) res = prices[j] - prices[i];
                }
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть цифри через кому:");
            string text = Console.ReadLine();
            // Можна провести проверку try,catch для обнаружения неправильного ввода
            string[] t = text.Split(',');
            int[] num = new int[t.Length];
            for (int i = 0; i < num.Length; i++) num[i] = Convert.ToInt32(t[i]);
            Console.WriteLine(Solution.MaxPrybutok(num));
        }
    }
}
