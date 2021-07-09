using System;

namespace uklon1st
{
    public class Solution
    {
        public static int[] SumaDvokhChysel(int[] nums, int target)
        {
            int[] res = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        res[0] = j;
                        res[1] = i;
                        return res; 
                    }
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
            int []num = new int[t.Length];
            Console.WriteLine("А зараз введіть target");
            int target = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num.Length; i++) num[i] = Convert.ToInt32(t[i]);
            {
                if (Solution.SumaDvokhChysel(num, target)[0] != Solution.SumaDvokhChysel(num, target)[1])
                    Console.WriteLine($"[{Solution.SumaDvokhChysel(num, target)[0]},{Solution.SumaDvokhChysel(num, target)[1]}]");
                else Console.WriteLine("Рішення відсутнє");
            }
        }
    }
}
