using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaMama.Core.Models
{
    public class PizzaIngredient
    {
        /// <summary>
        /// 
        /// </summary>
        public int PizzaId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("PizzaId")]
        public virtual Pizza Pizza { get; set; }
        //
        public int IngredientId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("IngredientId")]
        public virtual Ingredient Ingredient { get; set; }
    }
}
