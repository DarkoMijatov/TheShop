using System;
using Shop.Core.Interfaces;
using Shop.Core.Models;

namespace Shop.Core.Services
{
    public class SupplierService : ISupplierService
    {
        public bool ArticleInInventory(int id)
        {
            return new Random().NextDouble() >= 0.5;
        }

        public Article GetArticle(int id)
        {
            return new Article()
            {
                ID = id,
                Name_of_article = $"Article {id}",
                ArticlePrice = new Random().Next(100,500)
            };
        }
    }
}