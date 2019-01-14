/*
 * The TATasksController class accesses and maintains records in the Tasks table
 * of the Sail database, and returns appropriate responses to user's requests
 * that allow them to view, create, edit or delete task records in the Sail database
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
    public class TATasksController : Controller
    {
        private readonly SailContext _context;

        // Constructor for the TATasksController using context
        //provided by the dependency injection
        public TATasksController(SailContext context)
        {
            _context = context;
        }

        // Index is the default action for this controller that displays all
        // available tasks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tasks.OrderBy(a => a.Name).ToListAsync());
        }

        // The Details action returns the view displaying all fields of the selected task
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasks = await _context.Tasks
                .FirstOrDefaultAsync(m => m.TaskId == id);
            if (tasks == null)
            {
                return NotFound();
            }

            return View(tasks);
        }

        // This setup Create action returns a view with a blank input page to fill out
        // in order to create a new record
        public IActionResult Create()
        {
            return View();
        }

        // This post-back Create action (requiring Http Post) adds the new 
        // task record to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaskId,Name,Description")] Tasks tasks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tasks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tasks);
        }

        // This setup Edit action displays the details of the selected
        // record for update
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasks = await _context.Tasks.FindAsync(id);
            if (tasks == null)
            {
                return NotFound();
            }
            return View(tasks);
        }

        // This post-back Edit action (requiring Http Post) saves the updates 
        // to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TaskId,Name,Description")] Tasks tasks)
        {
            if (id != tasks.TaskId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tasks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TasksExists(tasks.TaskId))
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
            return View(tasks);
        }

        // This setup Delete action directs the user to the view that displays
        // the details of the selected task record and asks them to
        // confirm the intention to delete it
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasks = await _context.Tasks
                .FirstOrDefaultAsync(m => m.TaskId == id);
            if (tasks == null)
            {
                return NotFound();
            }

            return View(tasks);
        }

        // This post-back Delete action (requiring Http Post) deletes
        // the record specified by its id passed as argument from the database
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tasks = await _context.Tasks.FindAsync(id);
            _context.Tasks.Remove(tasks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Method verifying the existance of a boat type specified by its primary key
        private bool TasksExists(int id)
        {
            return _context.Tasks.Any(e => e.TaskId == id);
        }
    }
}
