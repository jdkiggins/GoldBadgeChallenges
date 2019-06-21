using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekThreeChallenges_01
{
    public class CafeMenu
    {
        public int MealNumber { get; set; }
        public string TypeOfOrder { get; set; }
        public double CostOfItem { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }

        public CafeMenu()
        { }
        public CafeMenu(int mealNumber, string typeOfOrder, string description, string ingredients, double costOfItem)
        {
            MealNumber = mealNumber;
            TypeOfOrder = typeOfOrder;
            CostOfItem = costOfItem;
            Description = description;
            Ingredients = ingredients;
        }
    }
}
