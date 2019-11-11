using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopping = new List<string>();

            Console.WriteLine("Make your shopping list (separate with comma): ");
            addGoods(shopping);

            Console.ReadLine();
        }

        public static List<string> addGoods(List<string> goodsList)
        {
            Console.Write("Add goods: ");
            var enter = Console.ReadLine();
            var splitEnter = enter.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            goodsList.AddRange(splitEnter);
            Console.Clear();
            printList(goodsList);
            return new List<string>();
        }
        public static List<string> deleteGoods(List<string> goodsList)
        {
            Console.Write("Remove goods: ");
            var removeItem = Console.ReadLine();

            goodsList.Remove(removeItem);
            Console.Clear();
            printList(goodsList);
            return new List<string>();
        }
        public static void printList(List<string> goodsList)
        {
            var currentDate = DateTime.Now;
            Console.WriteLine($"YOUR SHOPPING LIST: //modified {currentDate}");
            for (int i = 0; i < goodsList.Count; i++)
            {
                Console.WriteLine($"Item {i + 1}. {goodsList[i]} ");
            }
            Console.WriteLine("\n");
            Options(goodsList);
        }
        public static void Options(List<string> goodsList)
        {
            Console.WriteLine("Add/Remove/Quit list (a/r/q)");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "a")
            {
                addGoods(goodsList);

            }
            else if (userAnswer == "r")
            {
                deleteGoods(goodsList);

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Bye! Shop wisely");
            }
        }
    }
}
