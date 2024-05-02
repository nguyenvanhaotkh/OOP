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
        public void insertTable(string name, object obj)
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
        public void selectTable(string name)
        {
            switch (name)
            {
                case "product":
                    foreach(Product p in productTable)
                    {
                        Console.WriteLine(p.TxtData());
                    }
                    break;
                case "category":
                    foreach (Category c in categorieTable)
                    {
                        Console.WriteLine(c.TxtData());
                    }
                    break;
                case "accessotion":
                    foreach (Accessotion a in accessotionTable)
                    {
                        Console.WriteLine(a.TxtData());
                    }
                    break;
            }
        }
        public void updateTable(string name,object obj)
        {
            switch (name)
            {
                case "product":
                    Product newdatap = (Product)obj;
                    foreach(Product p in productTable)
                    {
                        if (p.GetId() == newdatap.GetId())
                        {
                            p.SetName(newdatap.name);
                            p.SetCategoryId(newdatap.categoryId);
                            break;
                        }
                    }
                    break;
                case "category":
                    Category newdatac = (Category)obj;
                    foreach (Category c in categorieTable)
                    {
                        if (c.GetId() == newdatac.GetId())
                        {
                            c.SetName(newdatac.name);
                            break;
                        }
                    }
                    break;
                case "accessotion":
                    Accessotion newdataa = (Accessotion)obj;
                    foreach (Accessotion a in accessotionTable)
                    {
                        if (a.GetId() == newdataa.GetId())
                        {
                            a.SetName(newdataa.name);
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
                    foreach (Product p in productTable)
                    {
                        if (p.GetId() == obj)
                        {
                            productTable.Remove(p);
                            break;
                        }
                    }
                    break;
                case "category":
                    foreach (Category c in categorieTable)
                    {
                        if (c.GetId() == obj)
                        {
                            categorieTable.Remove(c);
                            break;
                        }
                    }
                    break;
                case "accessotion":
                    foreach (Accessotion a in accessotionTable)
                    {
                        if (a.GetId() == obj)
                        {
                            accessotionTable.Remove(a);
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
