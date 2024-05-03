using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.dao
{
    class Database
    {
        public List<Product> productTable = new List<Product>();
        public List<Category> categorieTable = new List<Category>();
        public List<Accessotion> accessotionTable = new List<Accessotion>();
        private static Database _database;

        public static Database GetInstance()
        {
            if (_database == null)
            {
                _database = new Database();
            }
            return _database;
        }

        public void InsertTable(string name, object obj)
        {
            switch (name)
            {
                case "product":
                    productTable.Add((Product)obj);
                    break;
                case "category":
                    categorieTable.Add((Category)obj);
                    break;
                case "accessotion":
                    accessotionTable.Add((Accessotion)obj);
                    break;
            }
        }

        public void SelectTable(string name)
        {
            switch (name)
            {
                case "product":
                    foreach(Product product in productTable)
                    {
                        Console.WriteLine(product.TxtData());
                    }
                    break;
                case "category":
                    foreach (Category category in categorieTable)
                    {
                        Console.WriteLine(category.TxtData());
                    }
                    break;
                case "accessotion":
                    foreach (Accessotion accessotion in accessotionTable)
                    {
                        Console.WriteLine(accessotion.TxtData());
                    }
                    break;
            }
        }

        public void UpdateTable(string name,object obj)
        {
            switch (name)
            {
                case "product":
                    Product newproductdata = (Product)obj;
                    foreach(Product product in productTable)
                    {
                        if (product.GetId() == newproductdata.GetId())
                        {
                            product.SetName(newproductdata.name);
                            product.SetCategoryId(newproductdata.categoryId);
                            break;
                        }
                    }
                    break;
                case "category":
                    Category newcategorydata = (Category)obj;
                    foreach (Category category in categorieTable)
                    {
                        if (category.GetId() == newcategorydata.GetId())
                        {
                            category.SetName(newcategorydata.name);
                            break;
                        }
                    }
                    break;
                case "accessotion":
                    Accessotion newaccessotiondata = (Accessotion)obj;
                    foreach (Accessotion accessotion in accessotionTable)
                    {
                        if (accessotion.GetId() == newaccessotiondata.GetId())
                        {
                            accessotion.SetName(newaccessotiondata.name);
                            break;
                        }
                    }
                    break;
            }
        }

        public void Delete(string name, int obj)
        {
            switch (name)
            {
                case "product":
                    foreach (Product product in productTable)
                    {
                        if (product.GetId() == obj)
                        {
                            productTable.Remove(product);
                            break;
                        }
                    }
                    break;
                case "category":
                    foreach (Category category in categorieTable)
                    {
                        if (category.GetId() == obj)
                        {
                            categorieTable.Remove(category);
                            break;
                        }
                    }
                    break;
                case "accessotion":
                    foreach (Accessotion accessotion in accessotionTable)
                    {
                        if (accessotion.GetId() == obj)
                        {
                            accessotionTable.Remove(accessotion);
                            break;
                        }
                    }
                    break;
            }
        }

        public void DeleteAll(string name)
        {
            switch (name)
            {
                case "product":
                    productTable.Clear();
                    break;
                case "category":
                    categorieTable.Clear();
                    break;
                case "accessotion":
                    accessotionTable.Clear();
                    break;
            }
        }

    }
}
