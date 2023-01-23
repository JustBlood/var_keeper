using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using app.Models;
using app.Data;
namespace MvcMovie.Controllers;

public class VarsController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public VarsController(ApplicationDbContext context)
        {
            _context = context;
        }

    // GET: Vars/Details/5
    public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Vars == null)
            {
                return NotFound();
            }

            var var1 = await _context.Vars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (var1 == null)
            {
                return NotFound();
            }

            return View(var1);
        }

     // GET: Vars/Create
    public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Name,Value")] Vars var)
        {
            if (ModelState.IsValid)
            {
                _context.Add(var);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(var);
        }

    // 
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public string Welcome()
    {
        return "This is the Welcome action method...";
    }
}