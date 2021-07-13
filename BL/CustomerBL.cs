using System;
using System.Collections.Generic; //Involves a list
using DL; //Involves using DL
using Models; //Involves using Models
namespace BL
{
    public class CustomerBL : ICustomerBL
  
    {
        /// <summary>
        /// We are defining the dependenices this class needs in the constructor
        /// We do it this way (with interfaces) because we can easily switch out the implementation of RRDL when we want to change data source 
        /// (change from file system into database stored in the cloud)
        /// </summary>
        private ICustomerRepository _repo;
        private object return_repo;

        //private ICustomerRepository p_repo;

        public CustomerBL(ICustomerRepository p_repo) //This is default constructor. No parameters
        {
            _repo = p_repo;
        }
        public List<Customer> GetCustomers() //Get the customer list. 
        {
            return _repo.GetCustomers(); //Return the customer. 
        }
        public Customer AddCustomer(Customer p_customer)
        {
            return _repo.AddCustomer(p_customer); //Modified the AddCustomer from my BL. 
        }
        public List<Customer> GetCustomers(string findMe) //Function
        {
            // return _repo.GetCustomers(findMe);
            throw new NotImplementedException();
        }

        Customer ICustomerBL.AddCustomer(Customer p_customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomers(Customer p_customer)
        {
            throw new NotImplementedException();
        }
    }
}
