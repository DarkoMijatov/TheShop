using Shop.Core.Models;

namespace Shop.Core.Interfaces
{
    public interface ICachedSupplier
    {
        bool ArticleInInventory(int id);
        Article GetArticle(int id);
        void SetArticle(Article article);
    }
}