using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_4.Models
{

    public class FoodResponse
    {
        //This will gather the 4 inputs for user submitted
        //I made the first three will required
        //For the last one, I added a phone validation and paired that with a regular expression
        [Required]
        public string Name { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string FavoriteDish { get; set; }
        [RegularExpression(@"^\d{3}-\d{3}-\{4}$", ErrorMessage="Invalid Phone Number")]
        public string RestaurantPhone { get; set; }
    }
}
