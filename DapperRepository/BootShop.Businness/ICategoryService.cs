﻿using BootShop.Entities;
using System.Collections.Generic;

namespace BootShop.Businness
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
    }
}
