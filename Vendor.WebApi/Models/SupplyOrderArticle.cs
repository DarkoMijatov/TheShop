namespace Shop.Core.Models
{
    public class SupplyOrderArticle
    {
        public int Id { get; set; }
        public int SupplyOrderId { get; set; }
        public SupplyOrder SupplyOrder { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int Quantity { get; set; }
    }
}