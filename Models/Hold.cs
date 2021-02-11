using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{
    public static class Hold
    {
        //Here we create a new list to store the restaurant information in
        private static List<FoodResponse> food = new List<FoodResponse>();

        public static IEnumerable<FoodResponse> Food => food;

        //This method will use a parameter generated in our food response model and append that information to our created list
        public static void AddFood(FoodResponse x)
        {
            food.Add(x);
        }
    }
}
