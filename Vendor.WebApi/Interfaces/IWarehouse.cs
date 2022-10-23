using Shop.Core.Models;

namespace Shop.Core.Interfaces
{
    public interface IWarehouse
    {
        bool ArticleInInventory(int id);
        Article GetArticle(int id);
    }
}