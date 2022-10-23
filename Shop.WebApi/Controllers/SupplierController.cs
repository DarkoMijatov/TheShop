using System;
using System.Web.Http;
using Shop.Core.Models;
using Shop.Core.Interfaces;

namespace Shop.WebApi.Controllers
{
    public class SupplierController : ApiController
    {
        private IDatabaseDriver DatabaseDriver;
        private ILogger logger;
        private ISupplierService _supplierService;

        public SupplierController(IDatabaseDriver databaseDriver, ILogger logger, ISupplierService supplierService)
        {
            DatabaseDriver = databaseDriver;
            this.logger = logger;
            _supplierService = supplierService;
        }

        public bool ArticleInInventory(int id)
        {
            return _supplierService.ArticleInInventory(id);
        }

        public Article GetArtice(int id)
        {
            var articleExists = _supplierService.ArticleInInventory(id);
            if (articleExists)
            {
                return _supplierService.GetArticle(id);
            }
            else
            {
                throw new Exception("Article does not exist.");
            }
        }

        public void BuyArticle(Article article, int buyerId)
        {
            var id = article.ID;
            if (article == null)
            {
                throw new Exception("Could not order article");
            }

            logger.Debug("Trying to sell article with id=" + id);

            article.IsSold = true;
            article.SoldDate = DateTime.Now;
            article.BuyerUserId = buyerId;

            try
            {
                DatabaseDriver.Save(article);
                logger.Info("Article with id=" + id + " is sold.");
            }
            catch (ArgumentNullException ex)
            {
                logger.Error("Could not save article with id=" + id);
                throw new Exception("Could not save article with id");
            }
            catch (Exception)
            {
            }
        }
    }
}