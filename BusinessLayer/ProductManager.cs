using DataAccessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductManager
    {
        Repostory<Product> repopro = new Repostory<Product>();

        public List<Product> GetAll()
        {
            return repopro.List();
        }
        public List<Product> GetByName(string p)
        {
            return repopro.List(x => x.Name == p);
        }
    }
}
