namespace PizzaMama.Core.Models
{
    public class Categorie
    {
        /// <summary>
        /// 
        /// </summary>
        public int CategorieId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Cette collection représente la partie "Many" de la relation One-to-Many
        /// </summary>
        public virtual ICollection<Pizza> Pizzas { get; set; }
    }
}