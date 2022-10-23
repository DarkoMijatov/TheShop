using System;
using Shop.Core.Models;

namespace Shop.Core.Interfaces
{
    public interface ISupplierService
    {
        bool ArticleInInventory(int id);

        Article GetArticle(int id);
    }
}