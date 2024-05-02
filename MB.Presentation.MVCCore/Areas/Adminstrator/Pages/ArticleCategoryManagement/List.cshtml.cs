using MB.Application.Contracts;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Areas.Adminstrator.Pages.ArticleCategoryManagement
{
    public class IndexModel : PageModel
    {
        public List<ArticleCategoryViewModel> articleCategoryViewModels { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public IndexModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }
        public void OnGet()
        {
            articleCategoryViewModels = _articleCategoryApplication.List();
        }
    }
}
