using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.InvoiceSO
{
    public class AddInvoiceSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            // repository.Save(entity); ovaj save cuva samo u tabeli invoice, treba sacuvati i sve stavke
            throw new NotImplementedException("Ovo treba sami da uradite! :)");
        }
    }
}
