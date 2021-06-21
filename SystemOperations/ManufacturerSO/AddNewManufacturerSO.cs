using Domain;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.ManufacturerSO
{
    public class AddNewManufacturerSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Manufacturer m = (Manufacturer)entity;
            m.ManufacturerId = repository.GetNewId(m);
            repository.Save(entity);
        }
    }
}
