using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMama.Core.Models
{
    public class Pizza
    {
        /// <summary>
        /// 
        /// </summary>
        public int PizzaId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? CategorieId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("CategorieId")]
        public virtual Categorie Categorie { get; set; }
        public virtual ICollection<PizzaIngredient> PizzaIngredients { get; set; }
    }
}
