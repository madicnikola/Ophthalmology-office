using Domain;
using Domen;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations.ManufacturerSO
{
    public class GetAllManufacturersSO : SystemOperationBase
    {
        public List<Manufacturer> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Manufacturer()).Cast<Manufacturer>().ToList();
        }
    }
}
