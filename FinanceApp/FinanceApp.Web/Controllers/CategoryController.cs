using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinanceApp.Data;
using FinanceApp.Entities;
using FinanceApp.Web.Models.CategoryExpenses;
using FinanceApp.Web.Services.CategoryExpenses;

namespace FinanceApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _CategoryService;


        public CategoryController(ICategoryService category)
        {
            _CategoryService = category;
        }

        // GET: api/CategoryExpenses
        [HttpGet("[action]")]
        public async Task<IEnumerable<CategoryVwModel>> List()
        {
            return await _CategoryService.ListAsync();
        }

        // GET: api/CategoryExpenses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryVwModel>> GetCategory(int id)
        {
            var category = await _CategoryService.GetAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // POST: api/CategoryExpenses
    
        [HttpPost("[action]")]
        public async Task<ActionResult> Save([FromBody] AddCategoryVwModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
               await _CategoryService.AddAsync(model);

            }
            catch (DbUpdateConcurrencyException ex)
            {
                return BadRequest(ex);
            }

            return Ok(model);
        }

        // PUT: api/UpdateCategoryExpenses
        [HttpPut("[action]")]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryVwModel category)
        {
            int IdUpdated = 0; 

            if (!ModelState.IsValid)
            {
                return BadRequest(category);
            }
        
            try
            {
                IdUpdated = await _CategoryService.UpdateAsync(category);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (IdUpdated <= 0)
                {
                    return NotFound(ex);
                }              
            }

            return Ok(category);
        }


        // DELETE: api/CategoryExpenses/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Category>> DeleteCategory(int id)
        //{
        //    var categoryExpense = await _context.CategoryExpenses.FindAsync(id);
        //    if (categoryExpense == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.CategoryExpenses.Remove(categoryExpense);
        //    await _context.SaveChangesAsync();

        //    return categoryExpense;
        //}


    }
}
