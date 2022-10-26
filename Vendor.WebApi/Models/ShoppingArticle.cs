namespace Shop.Core.Models
{
    public class ShoppingArticle
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int Quantity { get; set; }
        public int ShoppingId { get; set; }
        public Shopping Shopping { get; set; }
    }
}