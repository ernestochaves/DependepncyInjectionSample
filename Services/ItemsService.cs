using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ItemsService
    {


        public List<Item> GetItems()
        {

            using (MyDataContext context = new MyDataContext())
            {
                return context.Items.ToList();
            }


        }

        public void Save(Item newItem)
        {
            using (MyDataContext context = new MyDataContext())
            {
                context.Items.Add(newItem);
                context.SaveChanges();
            }
        }
    }
}
