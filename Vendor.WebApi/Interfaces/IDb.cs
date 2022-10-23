using System.Collections.Generic;
using System.Linq;
using Shop.Core.Models;

namespace Shop.Core.Interfaces
{
    public interface IDb
    {
        Article GetById(int id);

        void Save(Article article);
    }
}