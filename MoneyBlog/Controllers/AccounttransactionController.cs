using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoneyBlog.Models;

namespace MoneyBlog.Controllers
{
    public class AccounttransactionController : Controller
    {
        private readonly blogsContext _context;

        public AccounttransactionController(blogsContext context)
        {
            _context = context;
        }

        // GET: Accounttransaction
        public async Task<IActionResult> Index()
        {
            return View(await _context.Accounttransaction.ToListAsync());
        }

        // GET: Accounttransaction/Dashboard
        public async Task<IActionResult> Dashboard(int? accountId)
        {
            return View(await _context.Accounttransaction.Where(at => at.AccountId == accountId).ToListAsync());
        }

        // GET: Accounttransaction/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accounttransaction = await _context.Accounttransaction
                .FirstOrDefaultAsync(m => m.TransactionId == id);
            if (accounttransaction == null)
            {
                return NotFound();
            }

            return View(accounttransaction);
        }

        // GET: Accounttransaction/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounttransaction/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionId,AccountId,Amount,Time,Recipient")] Accounttransaction accounttransaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accounttransaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accounttransaction);
        }

        // GET: Accounttransaction/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accounttransaction = await _context.Accounttransaction.FindAsync(id);
            if (accounttransaction == null)
            {
                return NotFound();
            }
            return View(accounttransaction);
        }

        // POST: Accounttransaction/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionId,AccountId,Amount,Time,Recipient")] Accounttransaction accounttransaction)
        {
            if (id != accounttransaction.TransactionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accounttransaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccounttransactionExists(accounttransaction.TransactionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(accounttransaction);
        }

        // GET: Accounttransaction/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accounttransaction = await _context.Accounttransaction
                .FirstOrDefaultAsync(m => m.TransactionId == id);
            if (accounttransaction == null)
            {
                return NotFound();
            }

            return View(accounttransaction);
        }

        // POST: Accounttransaction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accounttransaction = await _context.Accounttransaction.FindAsync(id);
            _context.Accounttransaction.Remove(accounttransaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccounttransactionExists(int id)
        {
            return _context.Accounttransaction.Any(e => e.TransactionId == id);
        }
    }
}
