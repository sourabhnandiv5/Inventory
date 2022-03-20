using InventoryManagement.Data;
using InventoryManagement.Models;
using InventoryManagement.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    public class UnitController : Controller
    {

        private readonly IUnit _Unit;
        public UnitController( IUnit _unit)
        {
            //  _Context = Context;
            _Unit = _unit;
        }
       
        public IActionResult Index()
        {
            List <Unit> list = _Unit.GetAllUnit();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {                  
            return View();
        }

        [HttpPost]
        public IActionResult Create(Unit unitdata)
        {
            _Unit.AddUnit(unitdata);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetDetails(int ID)
        {
            Unit list = _Unit.GetUnit(ID);
            return View(list);
        }

        [HttpGet]
        public IActionResult GetEdit(int ID)
        {
            Unit list = _Unit.GetUnit(ID);
            return View(list);
        }

        [HttpPost]
        public IActionResult GetEdit(Unit unit)
        {
            _Unit.EditUnit(unit);
            return RedirectToAction(nameof(Index));
        }


    }
}
