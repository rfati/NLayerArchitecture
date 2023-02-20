using BusinessLayer;
using BusinessLayer.ValidationRules;
using EntityLayer.Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerArchitecture
{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryManager cm = new CategoryManager();
            ProductManager pm = new ProductManager();
            Category c = new Category();
            Product p = new Product();
            //c.CategoryId = 3;
            //c.CategoryName = "Giyim";
            //cm.BLUpdate(c);
            foreach (var item in pm.GetAll())
            {
                Console.WriteLine("ID: " + item.ID + " - Ürün Adı: " + item.Name);
            }
            c.CategoryName = "DE";
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(c);
            if (results.IsValid)
            {
                cm.BLAdd(c);
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }
            //Category ct = new Category();
            //ct.CategoryName = "Halılar";
            //cm.BLAdd(ct);
            Console.Read();
        }
    }
}
