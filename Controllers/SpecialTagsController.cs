using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteHouse.Data;
using GraniteHouse.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraniteHouse.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class SpecialTagsController : Controller
    {
            private readonly ApplicationDbContext _db;
            public SpecialTagsController(ApplicationDbContext db)
            {
                _db = db;
            }
            
            public IActionResult Index()
            {
                return View(_db.SpecialTags.ToList());
            }
            
            // GET Create Action Method
            public IActionResult Create()
            {
                return View();
            }
            
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create(SpecialTags specialTags)
            {
                If(ModelState.IsValid)
                {
                    _db.Add(specialTags);
                    await _db.SaveChangesAsnc();
                    return RedirectToAction(Nameof(Index));
                }
                return View(specialTags);
            }
            
            
            // GET Action Method Edit
            public async Task<IActionResult> Edit(int? id)
            {
                if(id==null)
                {
                    return NotFound();
                }
                
                var specialTag = await _db.SpecialTags.FindAsync(Id);
                if(specialTag == null)
                {
                    return NotFound();
                }
                
                return View(specialTag);
                
            }
            
            
            
            
            
            
            
            
            
            
            // POST Edit Action Method
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, SpecialTags specialTags)
            {
                if(!id == specialTags.Id)
                {
                    return NotFound();
                }
                
                if(ModelState.IsValid)
                {
                    _db.Update(specialTags);
                    await _db.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                
            }
            
            
    }

}


