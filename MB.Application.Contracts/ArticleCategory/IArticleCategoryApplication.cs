﻿using MB.Application.Contracts.ArticleCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.Contracts
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
    }
}
