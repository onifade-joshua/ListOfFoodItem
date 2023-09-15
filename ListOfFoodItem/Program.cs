using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfFoodItem
{
    internal class Program
    {
        static void printImportantMeal(string[] arr)
        {
            string PersonName = "Joshua";
            string ProteinFood = arr[0];
            string CarbohydrateFood = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if(ProteinFood.Length < arr[i].Length)
                {
                    ProteinFood = arr[i];
                    Console.WriteLine($"Hey {PersonName} this {ProteinFood} is important for you to buy.");
                }
                else if(CarbohydrateFood.Length < arr[i].Length)
                {
                    CarbohydrateFood = arr[i];
                }
            }
            Console.WriteLine($"Hey get {CarbohydrateFood} as well!");
            Console.ReadLine();
        }
       public static void Main(string[] args)
        {
            string[] FoodList = { "Rice", "Cassava", "Noodles", "Tomatoes", "Fish", "Palm Oil", "Beans", "Salt", "Maggi" };
            printImportantMeal(FoodList);

            Console.WriteLine("Pls enter a key to continue...");
            Console.ReadKey();
        }
    }
}
