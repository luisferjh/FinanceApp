using AutoMapper;
using FinanceApp.Entities;
using FinanceApp.Web.Models.CategoryExpenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.MappingDTOs
{
    public class CategoryMapper:Profile
    {
        public CategoryMapper()
        {
            CreateMap<AddCategoryVwModel, Category>();
            CreateMap<Category, CategoryVwModel>();             
        }
    }
}
