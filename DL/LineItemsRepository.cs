using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Model = Models;
using Entity = DL.Entities;
using System.Linq;

namespace DL
{
    public class LineItemsRepository : ILineItemsRepository
    {
        private Entities.DemoDBContext _context;

        public LineItemsRepository(Entities.DemoDBContext p_context)
        {
            _context = p_context;
        }
        public bool AddLineItem(Entity.LineItem p_lineitem)
        {
            _context.LineItems.Add(new Entity.LineItem{
                LineItem_Id = p_lineitem.LineItem_Id,
                Product = p_lineitem.Product,
                Quantity = p_lineitem.Quantity, 
            });
            _context.SaveChanges();
            return true;
        }
        public List<Models.LineItem> GetAllLineItems()
        {
            return _context.LineItems.Select(
                lineitem =>
                    new Models.LineItem()
                    {
                        LineItem_Id = (int)lineitem.LineItem_Id,
                        Product = lineitem.Product,
                        Quantity = (int)lineitem.Quantity,
                    }
            ).ToList();
        }

        public Models.LineItem GetLineItem(int p_lineitemID)
        {
            var output =  _context.LineItems.Find(p_lineitemID);

            return              
                new Models.LineItem()
                {
                    LineItem_Id = output.lineItemId,
                    Product = output.Product,
                    Quantity = (int)output.Quantity,
                };
        }

        public List<Models.LineItem> GetLineItems()
        {
            throw new NotImplementedException();
        }
    }
}   