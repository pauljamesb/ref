using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraniteHouse.Data;
using GraniteHouse.Models;
using Microsoft.AspNetCore.Mvc;

namespace GraniteHouse.Admin.Controllers
{

    [Area("Admin")]
    public class SpecialTagsController : Controller
    {
            private readonly ApplicationDbContext _db;
            public SpecialTagsController(ApplicationDbContext db)
            {
                _db = db;
            }
    }

}


