using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using TeamA.Models;

namespace TeamA.Controllers
{
    public class TAMembershipController : Controller
    {
        private readonly SailContext _context;

        public TAMembershipController(SailContext context)
        {
            _context = context;
        }

        // GET: TAMembership
        public async Task<IActionResult> Index()
        {
            string memberId = "";
            string memberName = "";

            // look for member id in the query string; if foundm persist it
            if (Request.Query["memberId"].Count != 0)
            {
                memberId = Request.Query["memberId"];
                HttpContext.Session.SetString("memberId", memberId);
            }
            //if not, look for it in session variable
            else
            {
                if (HttpContext.Session.GetString(nameof(memberId)) != null)
                {
                    memberId = HttpContext.Session.GetString(nameof(memberId));
                }
            }
            //if not found there either, return to the TAMember Index view
            if (memberId == "")
            {
                TempData["message"] = "Please, select a member to see their membership";
                return RedirectToAction("Index", "TAMember");
            }

            // look for member's name in the query string
            if (Request.Query["memberName"].Count != 0)
            {
                memberName = Request.Query["memberName"];
                HttpContext.Session.SetString("memberName", memberName);
            }
            // if not found, look for member's name in the Members table based on memberId
            // and persist it
            else
            {
                memberName = _context.Member.FirstOrDefault(m => m.MemberId == int.Parse(memberId)).FullName;
            }
            HttpContext.Session.SetString("memberName", memberName);

            // save member name to ViewBag
            ViewBag.MemberFullName = memberName;

            // display the membership information filtered by memberId and sorted by the year
            var sailContext = _context.Membership.Include(m => m.Member)
                .Include(m => m.MembershipTypeNameNavigation)
                .Where(m => m.MemberId == int.Parse(memberId))
                .OrderByDescending(m => m.Year);

            return View(await sailContext.ToListAsync());
        }

        // GET: TAMembership/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership
                .Include(m => m.Member)
                .Include(m => m.MembershipTypeNameNavigation)
                .FirstOrDefaultAsync(m => m.MembershipId == id);
            if (membership == null)
            {
                return NotFound();
            }

            return View(membership);
        }

        // GET: TAMembership/Create
        public IActionResult Create()
        {
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType.OrderBy(m => m.MembershipTypeName), "MembershipTypeName", "MembershipTypeName");
            return View();
        }

        // POST: TAMembership/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MembershipId,MemberId,Year,MembershipTypeName,Fee,Comments,Paid")] Membership membership)
        {
            double annualFee = 0;
            double ratioToFull = 0;

            if (ModelState.IsValid)
            {
                if (_context.AnnualFeeStructure
                    .SingleOrDefault(a => a.Year == membership.Year)
                    .AnnualFee != null)
                {
                    annualFee = (double)_context.AnnualFeeStructure
                        .SingleOrDefault(a => a.Year == membership.Year)
                        .AnnualFee;
                }
                ratioToFull = _context.MembershipType.SingleOrDefault(a => 
                a.MembershipTypeName == membership.MembershipTypeName).RatioToFull;

                membership.Fee = annualFee * ratioToFull;

                _context.Add(membership);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType.OrderBy(m => m.MembershipTypeName), "MembershipTypeName", "MembershipTypeName", membership.MembershipTypeName);
            return View(membership);
        }

        // GET: TAMembership/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id < DateTime.Now.Year)
            {
                TempData["message"] = "You cannot edit previous year's membership records!";
                return RedirectToAction("Index");
            }

            var membership = await _context.Membership.FindAsync(id);
            if (membership == null)
            {
                return NotFound();
            }
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType.OrderBy(m => m.MembershipTypeName), "MembershipTypeName", "MembershipTypeName", membership.MembershipTypeName);
            return View(membership);
        }

        // POST: TAMembership/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MembershipId,MemberId,Year,MembershipTypeName,Fee,Comments,Paid")] Membership membership)
        {
            if (id != membership.MembershipId)
            {
                return NotFound();
            }           

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(membership);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MembershipExists(membership.MembershipId))
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
            ViewData["MembershipTypeName"] = new SelectList(_context.MembershipType.OrderBy(m => m.MembershipTypeName), "MembershipTypeName", "MembershipTypeName", membership.MembershipTypeName);
            return View(membership);
        }

        // GET: TAMembership/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = await _context.Membership
                .Include(m => m.Member)
                .Include(m => m.MembershipTypeNameNavigation)
                .FirstOrDefaultAsync(m => m.MembershipId == id);
            if (membership == null)
            {
                return NotFound();
            }

            return View(membership);
        }

        // POST: TAMembership/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var membership = await _context.Membership.FindAsync(id);
            _context.Membership.Remove(membership);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MembershipExists(int id)
        {
            return _context.Membership.Any(e => e.MembershipId == id);
        }
    }
}
