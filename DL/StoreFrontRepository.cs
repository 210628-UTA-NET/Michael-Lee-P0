using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Model = Models;
using Entity = DL.Entities;
using System.Linq;
using Models;

namespace DL
{ 
     public class StoreFrontRepository : IStoreFrontRepository
    {
        private Entities.DemoDBContext _context;
        public StoreFrontRepository(Entity.DemoDBContext p_context)
        {
            _context = p_context;
        }
        public Model.StoreFront AddStoreFront(Model.StoreFront p_storeFront)
        {
            _context.StoreFront.(new DL.Entities.StoreFront
            {
                Id = p_storeFront.Store_Id,
                StoreName = p_storeFront.StoreName,
                Address = p_storeFront.Address,
                Inventory = p_storeFront.Inventory,
                ListofOrder = p_storeFront.ListofOrder_Id,
            });

            _context.SaveChanges();
            return p_storeFront;
        }

        public List<Model.StoreFront> GetAllStoreFront()
        {
            //Method Syntax way
            return _context.StoreFront.Select(
                store => 
                    new Model.StoreFront()
                    {
                        Store_Id = store.Store_Id,
                        StoreName = store.StoreName,
                        Address = store.Address,
                        Inventory = store.Inventory,
                        ListofOrder_Id = store.ListofOrder_Id, 
                    }
            ).ToList();
        }

        public List<Customer> GetStoreFront()
        {
            throw new NotImplementedException();
        }
    }        
}