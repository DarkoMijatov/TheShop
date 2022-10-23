using Shop.Core.Models;

namespace Shop.Core.Interfaces
{
    public interface IDatabaseDriver
    {
        Article GetById(int id);

        void Save(Article article);
    }
}