using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{
    //This class will hold restaurant objects, and each piece of individual informaiton for that restaurant
    public class Food
    {
        //This will act as the instructor, which will receive a rank parameter when the class is created
        //This is so the rank will be readable only
        public Food(int rank)
        {
            Rank = rank;
        }
        //Here are the restaurant properties
        //The rank will be read only
        //Some of these are required
        //Some contain default messages if not included
        //Those with a question mark protect against nulls
        [Required]
        public int Rank { get; }
        [Required]
        public string RestaurantName { get; set; }
        public string? FavoriteDish { get; set; } = "It's all tasty!";
        [Required]
        public string Address { get; set; }
        public string? RestaurantPhone { get; set; }
        public string? Website { get; set; } = "Coming soon";


        //This will affect all instances of the restaurant object, makes it easier to access for exterior classes
        //This will return all the restaurants in the list
        public static Food[] GetFood()
        {

            Food f1 = new Food(1)
            {
                RestaurantName = "TacoBell",
                FavoriteDish = "Baja Blast",
                Address = "1244 N Freedom Blvd, Provo, UT 84604",
                RestaurantPhone = "(801) 377-7080",
                Website = "tacobell.com"
            };
            Food f2 = new Food(2)
            {
                RestaurantName = "Panda Express",
                FavoriteDish = "Orange Chicken",
                Address = "1240 N University Ave, Provo, UT 84604",
                RestaurantPhone = "(801) 818-0111)",
                Website = "pandaexpress.com"
            };
            Food f3 = new Food(3)
            {
                RestaurantName = "Chipotle Mexican Grill",
                FavoriteDish = "Steak Tacos",
                Address = "715 E University Pkwy, Orem, UT 84097",
                RestaurantPhone = "(801) 225-4364",
                Website = "locations.chipotle.com"
            };
            Food f4 = new Food(4)
            {
                RestaurantName = "In-N-Out Burger",
                FavoriteDish = "Hamburger",
                Address = "350 E University Pkwy, Orem, UT 84058",
                RestaurantPhone = "(800) 786-1000",
                Website = "locations.in-n-out.com"
            };
            Food f5 = new Food(5)
            {
                RestaurantName = "Mo' Bettahs",
                FavoriteDish = "Katsu Chicken",
                Address = "1385 S State St, Orem, UT 84097",
                RestaurantPhone = "(801) 960-4616",
                Website = "mobettahs.com"
            };
            //This makes sure that the created restaurants are actually returned
            return new Food[] { f1, f2, f3, f4, f5 };
        }
    }
}
