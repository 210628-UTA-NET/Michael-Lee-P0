using System;
using DL;
using Models;
using System.Collections.Generic;

namespace BL
{
    public class StoreFrontBL : IStoreFrontBL
    {
        private IStoreFrontRepository _repo;     
        public StoreFrontBL(IStoreFrontRepository p_repo)
        {
            _repo = p_repo;
        }
        // public List<StoreFront> GetStoreFronts() //This is creating a list for Json file. 
        // {
        //     return _repo.AddStore
        // }
    }
}