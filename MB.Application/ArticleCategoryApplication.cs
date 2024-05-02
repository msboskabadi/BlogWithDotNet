using MB.Application.Contracts;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Infra.EFCore.Repositories;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _repository;

        public ArticleCategoryApplication(IArticleCategoryRepository repository)
        {
            _repository = repository;
        }
        public List<ArticleCategoryViewModel> List()
        {
            var articleCategories = _repository.GetAll();
            var result = new List<ArticleCategoryViewModel>();
            foreach(var item in articleCategories)
            {
                result.Add(new ArticleCategoryViewModel
                {
                    Id = item.Id,
                    Title = item.Title,
                    IsDeleted = item.IsDeleted,
                    CreationDate = item.CreationDate.ToString()
                });
            }
            return result;  
        }
    }
}