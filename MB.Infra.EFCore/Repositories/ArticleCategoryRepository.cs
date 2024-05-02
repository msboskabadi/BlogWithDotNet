using MB.Domain.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Infra.EFCore.Repositories
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MasterBloggerContext _context;

        public ArticleCategoryRepository(MasterBloggerContext context)
        {
            _context = context;
        }
        public void Create(ArticleCategory category)
        {
            _context.ArticleCategoris.Add(category);
            _context.SaveChanges();
        }

        public List<ArticleCategory> GetAll()
        {
            return _context.ArticleCategoris.ToList();
        }
    }
}
