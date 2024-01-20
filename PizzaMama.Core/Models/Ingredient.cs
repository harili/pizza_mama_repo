using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMama.Core.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Nom { get; set; }
        public virtual ICollection<PizzaIngredient> PizzaIngredients { get; set; }
    }
}
