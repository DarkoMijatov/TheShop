using Shop.Core.Models;

namespace Shop.Core.Interfaces
{
    public interface IDealer2
    {
        bool ArticleInInventory(int id);

        Article GetArticle(int id);
    }
}