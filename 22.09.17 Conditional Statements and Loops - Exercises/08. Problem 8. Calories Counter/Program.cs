using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int calories = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine();
                string lowerLettersIngredients = ingredient.ToLower();
                //to lower letters 
                switch (lowerLettersIngredients)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
