using Shop.Core.Models;

namespace Shop.Core.Interfaces
{
    public interface IDealer1
    {
        bool ArticleInInventory(int id);

        Article GetArticle(int id);
    }
}