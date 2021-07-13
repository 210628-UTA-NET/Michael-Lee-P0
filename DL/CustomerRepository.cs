using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using Model = Models;
using Entity = DL.Entities;

namespace DL
{
    public class CustomerRepository : ICustomerRepository
    {
        private Entities.DemoDBContext _context;

        public CustomerRepository(Entities.DemoDBContext p_context)
        {
            _context = p_context;
        }
        public bool AddCustomer(Entity.Customer p_customer)
        {
            _context.Customers.Add(new Entity.Customer{
                Customer_Id = p_customer.Customer_Id,
                FirstName = p_customer.FirstName,
                LastName = p_customer.LastName,
                Address = p_customer.Address,
                Email = p_customer.Email, 
            });
            _context.SaveChanges();
            return true;
        }

        public void AddCustomer(Model.Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Models.Customer> GetAllCustomers()
        {
            return _context.Customers.Select(
                customer =>
                    new Models.Customer()
                    {
                        Customer_Id = customer.CustomerId,
                        FirstName = customer.FirstName,
                        LastName = customer.LastName,
                        Address = customer.Address,
                        Email = customer.Email,
                    }
            ).ToList();
        }

        public Models.Customer GetCustomer(int p_customerID)
        {
            var output =  _context.Customers.Find(p_customerID);

            return              
                new Models.Customer()
                {
                    Customer_Id = output.CustomerId,
                    FirstName = output.FirstName,
                    LastName = output.LastName,
                    Address = output.Address,
                    Email = output.Email,
                };
        }

        public List<Model.Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        Model.Customer ICustomerRepository.AddCustomer(Model.Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}   
    
        
