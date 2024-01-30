using Core.CrossCuttingConcerns.Exceptions;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class IndividualCustomerBusinessRules
    {
        public void CheckIfIndividualCustomerExists(IndividualCustomer? individualCustomer)
        {
            if (individualCustomer is null)
                throw new NotFoundException("Individual customer not found.");
        }
    }
}
