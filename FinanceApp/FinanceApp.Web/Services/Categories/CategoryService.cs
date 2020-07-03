using AutoMapper;
using FinanceApp.Data;
using FinanceApp.Entities;
using FinanceApp.Web.Models.CategoryExpenses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Web.Services.CategoryExpenses
{
    public class CategoryService : ICategoryService
    {
        private readonly DbContextFinance _context;
        private readonly IMapper _mapper;

        public CategoryService(DbContextFinance context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CategoryVwModel>> ListAsync()
        {
            var category = await _context.Categories.ToListAsync();
            return _mapper.Map<List<CategoryVwModel>>(category);
        }

        public async Task<CategoryVwModel> GetAsync(int id)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(f => f.IdCategory == id);
            return _mapper.Map<CategoryVwModel>(category);
        }

        public async Task<int> AddAsync(AddCategoryVwModel model)
        {
            Category categoryExpense = _mapper.Map<Category>(model);
            await _context.Categories.AddAsync(categoryExpense);
            return categoryExpense.IdCategory;
        }

        public async Task<int> UpdateAsync(UpdateCategoryVwModel model)
        {
            Category category = _context.Categories.FirstOrDefault(f => f.IdCategory == model.IdCategory);

            category.Code = model.Code;
            category.Description = model.Description;
            category.Icono = model.Icono;
            category.Status = model.Status;

            await _context.SaveChangesAsync();
            return model.IdCategory;
            // _context.Entry(category).State = EntityState.Modified;

        }

        public async Task DeleteAsync(DeleteCategoryVwModel model)
        {
            Category category = _context.Categories.FirstOrDefaultAsync(f => f.IdCategory == model.IdCategory).Result;
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            Category category =  _context.Categories.FirstOrDefaultAsync(f => f.IdCategory == id).Result;
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public Task DeleteAsync(IEnumerable<DeleteCategoryVwModel> t)
        {
            throw new NotImplementedException();
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.IdCategory == id);
        }
    }
}
