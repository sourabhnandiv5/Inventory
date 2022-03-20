using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Repository
{
   public interface IUnit
    {
        List< Unit> GetAllUnit();
        void AddUnit(Unit unit);       
        Unit GetUnit(int ID);
        void EditUnit(Unit unit);
    }
}
