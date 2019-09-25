using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MagicUNI.Models;

namespace MagicUNI.Controllers
{
    public class StudentiController : Controller
    {
        private readonly MagicContext _context;

        public StudentiController(MagicContext context)
        {
            _context = context;
        }

        // GET: Studenti
        public async Task<IActionResult> Index()
        {
            return View(await _context.Studenti.ToListAsync());
        }
    }
}