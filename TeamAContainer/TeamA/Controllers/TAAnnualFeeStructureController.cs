using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeamA.Models;

namespace TeamA.Controllers
{
    public class TAAnnualFeeStructureController : Controller
    {
        private readonly SailContext _context;

        public TAAnnualFeeStructureController(SailContext context)
        {
            _context = context;
        }

        // GET: TAAnnualFeeStructure
        public async Task<IActionResult> Index()
        {
            return View(await _context.AnnualFeeStructure.OrderByDescending(a => a.Year).ToListAsync());
        }

        // GET: TAAnnualFeeStructure/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annualFeeStructure = await _context.AnnualFeeStructure
                .FirstOrDefaultAsync(m => m.Year == id);
            if (annualFeeStructure == null)
            {
                return NotFound();
            }

            return View(annualFeeStructure);
        }

        // GET: TAAnnualFeeStructure/Create
        public IActionResult Create()
        {
            var recentYearFee = _context.AnnualFeeStructure.OrderByDescending(a => a.Year).First();
            return View(recentYearFee);
        }

        // POST: TAAnnualFeeStructure/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Year,AnnualFee,EarlyDiscountedFee,EarlyDiscountEndDate,RenewDeadlineDate,TaskExemptionFee,SecondBoatFee,ThirdBoatFee,ForthAndSubsequentBoatFee,NonSailFee,NewMember25DiscountDate,NewMember50DiscountDate,NewMember75DiscountDate")] AnnualFeeStructure annualFeeStructure)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(annualFeeStructure);
                    await _context.SaveChangesAsync();
                    // if save was successful, display a message
                    TempData["message"] = $"Record added for year {annualFeeStructure.Year}";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", $"error while saving annual fee structure: {ex.GetBaseException().Message}");
                    return View(annualFeeStructure);
                }
            }
            return View(annualFeeStructure);
        }

        // GET: TAAnnualFeeStructure/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (id < DateTime.Now.Year)
            {
                TempData["message"] = "You cannot edit annual fees from previous years!";
                return RedirectToAction(nameof(Index));
            }

            var annualFeeStructure = await _context.AnnualFeeStructure.FindAsync(id);
            if (annualFeeStructure == null)
            {
                return NotFound();
            }
            return View(annualFeeStructure);
        }

        // POST: TAAnnualFeeStructure/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Year,AnnualFee,EarlyDiscountedFee,EarlyDiscountEndDate,RenewDeadlineDate,TaskExemptionFee,SecondBoatFee,ThirdBoatFee,ForthAndSubsequentBoatFee,NonSailFee,NewMember25DiscountDate,NewMember50DiscountDate,NewMember75DiscountDate")] AnnualFeeStructure annualFeeStructure)
        {
            if (id != annualFeeStructure.Year)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (annualFeeStructure.Year < DateTime.Now.Year)
                    {
                        TempData["message"] = "You cannot edit fees from previous years!";
                        return RedirectToAction(nameof(Index));
                    }
                    _context.Update(annualFeeStructure);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnnualFeeStructureExists(annualFeeStructure.Year))
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
            return View(annualFeeStructure);
        }

        // GET: TAAnnualFeeStructure/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var annualFeeStructure = await _context.AnnualFeeStructure
                .FirstOrDefaultAsync(m => m.Year == id);
            if (annualFeeStructure == null)
            {
                return NotFound();
            }

            return View(annualFeeStructure);
        }

        // POST: TAAnnualFeeStructure/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var annualFeeStructure = await _context.AnnualFeeStructure.FindAsync(id);
            _context.AnnualFeeStructure.Remove(annualFeeStructure);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnnualFeeStructureExists(int id)
        {
            return _context.AnnualFeeStructure.Any(e => e.Year == id);
        }
    }
}
