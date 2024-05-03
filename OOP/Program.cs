using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.dao;
using OOP.entity;

namespace OOP
{
    class Program
    {
        private string product = "product";
        private string category = "category";
        private string accessotion = "accessotion";
        static void Main(string[] args)
        {
            Database db = Database.GetInstance();
            Program p = new Program();
            p.FunctionSelection(db);
        }

        private void FunctionSelection(Database db)
        {
            Console.WriteLine("1-Insert");
            Console.WriteLine("2-Select");
            Console.WriteLine("3-Update");
            Console.WriteLine("4-Delete");
            Console.WriteLine("5-DeleteAll");
            Console.WriteLine("6-Exit");
            int iselect = Convert.ToInt32(Console.ReadLine());
            switch (iselect)
            {
                case 1:
                    Insert(db);
                    break;
                case 2:
                    Select(db);
                    break;
                case 3:
                    Update(db);
                    break;
                case 4:
                    Delete(db);
                    break;
                case 5:
                    DeleteAll(db);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("value does not match");
                    FunctionSelection(db);
                    break;

            }
        }

        private void Insert(Database db)
        {
            Console.WriteLine("Enter Entity:");
            string txt = Console.ReadLine();
            switch (txt)
            {
                case "product":
                    Product np = (Product)ObjectFormInput(txt);
                    db.InsertTable(product, np);
                    FunctionSelection(db);
                    break;
                case "category":
                    Category nc = (Category)ObjectFormInput(txt);
                    db.InsertTable(category, nc);
                    FunctionSelection(db);
                    break;
                case "accessotion":
                    Accessotion na = (Accessotion)ObjectFormInput(txt);
                    db.InsertTable(accessotion, na);
                    FunctionSelection(db);
                    break;
                default:
                    Console.WriteLine("value does not match");
                    Insert(db);
                    break;
            }
        }

        private void Select(Database db)
        {
            Console.WriteLine("Enter Entity:");
            string txt = Console.ReadLine();
            switch (txt)
            {
                case "product":
                    if (db.productTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable(product);
                    FunctionSelection(db);
                    break;
                case "category":
                    if (db.categorieTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable(category);
                    FunctionSelection(db);
                    break;
                case "accessotion":
                    if (db.accessotionTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable(accessotion);
                    FunctionSelection(db);
                    break;
                default:
                    Console.WriteLine("value does not match");
                    Select(db);
                    break;
            }
        }

        private void Update(Database db)
        {
            Console.WriteLine("Enter Entity:");
            string txt = Console.ReadLine();
            switch (txt)
            {
                case "product":
                    if (db.productTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable(product);
                    int productId = InputId();
                    if (!CheckId(txt, productId))
                    {
                        FunctionSelection(db);
                        return;
                    }
                    Product newProduct = (Product)ObjectFormInput(txt);
                    newProduct.SetId(productId);
                    db.UpdateTable(product, newProduct);
                    FunctionSelection(db);
                    break;
                case "category":
                    if (db.categorieTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable(category);
                    int categoryId = InputId();
                    if (!CheckId(txt, categoryId))
                    {
                        FunctionSelection(db);
                        return;
                    }
                    Category newCategory = (Category)ObjectFormInput(txt);
                    newCategory.SetId(categoryId);
                    db.UpdateTable(category, newCategory);
                    FunctionSelection(db);
                    break;
                case "accessotion":
                    if (db.accessotionTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable(accessotion);
                    int accessotionId = InputId();
                    if (!CheckId(txt, accessotionId))
                    {
                        FunctionSelection(db);
                        return;
                    }
                    Accessotion newAccessotion = (Accessotion)ObjectFormInput(txt);
                    newAccessotion.SetId(accessotionId);
                    db.UpdateTable(accessotion, newAccessotion);
                    FunctionSelection(db);
                    break;
                default:
                    Console.WriteLine("value does not match");
                    Update(db);
                    break;
            }
        }

        private void Delete(Database db)
        {
            Console.WriteLine("Enter Entity:");
            string txt = Console.ReadLine();
            switch (txt)
            {
                case "product":
                    if (db.productTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable(product);
                    Console.WriteLine("Select Product Id:");
                    int pid = Convert.ToInt32(Console.ReadLine());
                    db.Delete(product, pid);
                    FunctionSelection(db);
                    break;
                case "category":
                    if (db.categorieTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable(category);
                    Console.WriteLine("Select Product Id:");
                    int cid = Convert.ToInt32(Console.ReadLine());
                    db.Delete(category, cid);
                    FunctionSelection(db);
                    break;
                case "accessotion":
                    if (db.accessotionTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable(accessotion);
                    Console.WriteLine("Select Product Id:");
                    int aid = Convert.ToInt32(Console.ReadLine());
                    db.Delete(accessotion, aid);
                    FunctionSelection(db);
                    break;
                default:
                    Console.WriteLine("value does not match");
                    Delete(db);
                    break;
            }
        }

        private void DeleteAll(Database db)
        {
            Console.WriteLine("Enter Entity:");
            string txt = Console.ReadLine();
            switch (txt)
            {
                case "product":
                    if (db.productTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    Console.WriteLine("Delete...");
                    db.DeleteAll(product);
                    FunctionSelection(db);
                    break;
                case "category":
                    if (db.categorieTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    Console.WriteLine("Delete...");
                    db.DeleteAll(category);
                    FunctionSelection(db);
                    break;
                case "accessotion":
                    if (db.accessotionTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    Console.WriteLine("Delete...");
                    db.DeleteAll(accessotion);
                    FunctionSelection(db);
                    break;
                default:
                    Console.WriteLine("value does not match");
                    DeleteAll(db);
                    break;
            }
        }

        private object ObjectFormInput(string name)
        {
            if(name == product)
            {
                int productId = Database.GetInstance().productTable.Count();
                Console.WriteLine("Enter New Name:");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter New Category Id:");
                int productCategoryId = Convert.ToInt32(Console.ReadLine());
                return new Product(productId,productName, productCategoryId);
            }
            if(name == category)
            {
                int categoryId = Database.GetInstance().productTable.Count();
                Console.WriteLine("Enter New Name:");
                string categoryName = Console.ReadLine();
                return new Category(categoryId, categoryName);
            }
            int accessotionId = Database.GetInstance().productTable.Count();
            Console.WriteLine("Enter New Name:");
            string accessotionName = Console.ReadLine();
            return new Accessotion(accessotionId, accessotionName);
        }
        private int InputId()
        {
            Console.WriteLine("Select Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        private bool CheckId(string name, int id)
        {
            if (name == product && Database.GetInstance().productTable.FirstOrDefault(productObject => productObject.GetId() == id) != null)
            {
                return true;
            }
            if (name == category && Database.GetInstance().categorieTable.FirstOrDefault(categoryObject => categoryObject.GetId() == id) != null)
            {
                return true;
            }
            if (name == accessotion && Database.GetInstance().accessotionTable.FirstOrDefault(accessotionObject => accessotionObject.GetId() != id) == null)
            {
                return true;
            }
            Console.WriteLine("id does not exist");
            return false;
        }
    }
}
