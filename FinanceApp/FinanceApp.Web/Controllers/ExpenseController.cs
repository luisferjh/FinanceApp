﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Web.Models.Expenses;
using FinanceApp.Web.Services.Expenses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseController : ControllerBase
    {
        private readonly IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        // GET: api/Expense
        [HttpGet("[action]")]
        public async Task<IEnumerable<ExpenseViewModel>> List()
        {
            return await _expenseService.ListAsync();
        }

        //// GET: api/Expense/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Expense>> GetExpenses(int id)
        //{
        //    var expenses = await _context.Expenses.FindAsync(id);

        //    if (expenses == null)
        //    {
        //        return NotFound();
        //    }

        //    return expenses;
        //}

        //// PUT: api/Expense/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutExpenses(int id, Expense expenses)
        //{
        //    if (id != expenses.IdExpense)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(expenses).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ExpensesExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Expense
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<Expense>> PostExpenses(Expense expenses)
        //{
        //    _context.Expenses.Add(expenses);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetExpenses", new { id = expenses.IdExpense }, expenses);
        //}

        //// DELETE: api/Expense/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Expense>> DeleteExpenses(int id)
        //{
        //    var expenses = await _context.Expenses.FindAsync(id);
        //    if (expenses == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Expenses.Remove(expenses);
        //    await _context.SaveChangesAsync();

        //    return expenses;
        //}

        //private bool ExpensesExists(int id)
        //{
        //    return _context.Expenses.Any(e => e.IdExpense == id);
        //}
    }
}