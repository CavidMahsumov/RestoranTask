using RestoranTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoranTask.Models
{
    public class MealListViewModel
    {
        public List<Drink> drinks { get; set; }
        public List<FastFood> fastfoods { get; set; }
        public List<Meal> meals { get; set; }

    }
}
