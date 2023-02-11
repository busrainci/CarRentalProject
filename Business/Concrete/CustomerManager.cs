using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
      
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
            
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new ErrorResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll(Customer customer)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomerListed);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new ErrorResult(Messages.CustomerNotUpdate);
        }
    }
}
