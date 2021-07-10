using System;
namespace uklon3rd
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int []i=null;
                int j=i[0]*5; //обращение к масиву невозможен, так как елементи и размер, еще не указан 
            }
            catch (NullReferenceException exp)
            {
                Console.WriteLine("NullReferenceException: " + exp.Message);
            }
        }
    }
}
