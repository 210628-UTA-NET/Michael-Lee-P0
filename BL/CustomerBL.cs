using System;
using System.Collections.Generic; //Involves a list
using DL; //Involves using DL
using Models; //Involves using Models
namespace BL
{
    public class CustomerBL
  
    {
        /// <summary>
        /// We are defining the dependenices this class needs in the constructor
        /// We do it this way (with interfaces) because we can easily switch out the implementation of RRDL when we want to change data source 
        /// (change from file system into database stored in the cloud)
        /// </summary>
        private IRepository _repo;
        public CustomerBL() //This is default constructor. No parameters
        {
            _repo = new Repository(); //The new word has to be tied to the constructor. 
        }
        public CustomerBL(IRepository p_repo)
        {
            _repo = p_repo;
        }
        public List<Customer> GetCustomers() //Get the customer list. 
        {
            return _repo.GetCustomers(); //Return the customer. 
        }
    }
}
