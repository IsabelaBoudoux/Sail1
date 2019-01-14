/*
 * The TABoatTypeController class accesses and maintains records in the boatType table
 * of the Sail database, and returns appropriate responses to user's requests
 * that allow them to view, create, edit or delete boat type records in the Sail database
 * Assignment 1
 * Revision History
 *          Azza Elgendy, Isabela Boudoux, Iryna Shynkevych 2018-09-14 : created
 */
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
    public class TABoatTypeController : Controller
    {
        private readonly SailContext _context;

        // Constructor for the TABoatTypeController using context
        //provided by the dependency injection
        public TABoatTypeController(SailContext context)
        {
            _context = context;
        }

        // Index is the default action for this controller that displays all
        // available boat types and provides links to the views of other
        // actions (create, edit, details and delete)
        public async Task<IActionResult> Index()
        {
            return View(await _context.BoatType.OrderBy(m=>m.Name).ToListAsync());
        }

        // The Details action returns the view displaying all fields of the selected boat type
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boatType = await _context.BoatType
                .FirstOrDefaultAsync(m => m.BoatTypeId == id);
            if (boatType == null)
            {
                return NotFound();
            }

            return View(boatType);
        }

        // This setup Create action returns a view with a blank input page to fill out
        // in order to create a new boat type record
        public IActionResult Create()
        {
            return View();
        }

        // This post-back Create action (requiring Http Post) adds the new 
        // boat type record to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BoatTypeId,Name,Description,Chargeable,Sail,Image")] BoatType boatType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(boatType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(boatType);
        }

        // This setup Edit action displays the details of the selected
        // record for update
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boatType = await _context.BoatType.FindAsync(id);
            if (boatType == null)
            {
                return NotFound();
            }
            return View(boatType);
        }

        // This post-back Edit action (requiring Http Post) saves the updates 
        // to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BoatTypeId,Name,Description,Chargeable,Sail,Image")] BoatType boatType)
        {
            if (id != boatType.BoatTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(boatType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BoatTypeExists(boatType.BoatTypeId))
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
            return View(boatType);
        }

        // This setup Delete action directs the user to the view that displays
        // the details of the selected boat type record and asks them to
        // confirm the intention to delete it
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var boatType = await _context.BoatType
                .FirstOrDefaultAsync(m => m.BoatTypeId == id);
            if (boatType == null)
            {
                return NotFound();
            }

            return View(boatType);
        }

        // This post-back Delete action (requiring Http Post) deletes
        // the record specified by its id passed as argument from the database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boatType = await _context.BoatType.FindAsync(id);
            _context.BoatType.Remove(boatType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Method verifying the existance of a boat type specified by its primary key
        private bool BoatTypeExists(int id)
        {
            return _context.BoatType.Any(e => e.BoatTypeId == id);
        }
    }
}
