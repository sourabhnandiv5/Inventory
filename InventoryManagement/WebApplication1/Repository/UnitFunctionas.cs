using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
    public class UnitFunctionas : IUnit
    {
        private readonly InventoryContext _Context;     
      

        public UnitFunctionas(InventoryContext Context)
        {
            _Context = Context;
        }
        public void AddUnit(Unit _unit)
        {
            _Context.Units.Add(_unit);
            _Context.SaveChanges();
           
        }
        
        public Unit GetUnit(int ID)
        {
            return _Context.Units.Where(id => id.ID == ID).FirstOrDefault();
        }
        public List<Unit> GetAllUnit()
        {
          return  _Context.Units.ToList();
        }

        public void EditUnit(Unit unit)
        {
             _Context.Units.Attach(unit);
             _Context.Entry(unit).State = EntityState.Modified;
             _Context.SaveChanges();
        }
    }
}
