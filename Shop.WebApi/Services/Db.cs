using System.Collections.Generic;
using System.Linq;
using Shop.Core.Interfaces;
using Shop.Core.Models;

namespace Shop.WebApi.Services
{
    public class Db : IDb
    {
        private List<Article> _articles = new List<Article>();

        public Article GetById(int id)
        {
            return _articles.Single(x => x.Id == id);
        }

        public void Save(Article article)
        {
            _articles.Add(article);
        }
    }
}