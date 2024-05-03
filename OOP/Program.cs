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
                    int pid = db.productTable.Count();
                    Console.WriteLine("Enter Name:");
                    string ptxtname = Console.ReadLine();
                    Console.WriteLine("Enter Category Id:");
                    int pcategoryid = Convert.ToInt32(Console.ReadLine());
                    Product np = new Product(pid, ptxtname, pcategoryid);
                    db.InsertTable("product", np);
                    FunctionSelection(db);
                    break;
                case "category":
                    int cid = db.categorieTable.Count();
                    Console.WriteLine("Enter Name:");
                    string ctxtname = Console.ReadLine();
                    Category nc = new Category(cid, ctxtname);
                    db.InsertTable("product", nc);
                    FunctionSelection(db);
                    break;
                case "accessotion":
                    int aid = db.accessotionTable.Count();
                    Console.WriteLine("Enter Name:");
                    string atxtname = Console.ReadLine();
                    Category na = new Category(aid, atxtname);
                    db.InsertTable("product", na);
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
                    db.SelectTable("product");
                    FunctionSelection(db);
                    break;
                case "category":
                    if (db.categorieTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable("product");
                    FunctionSelection(db);
                    break;
                case "accessotion":
                    if (db.accessotionTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable("product");
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
                    db.SelectTable("product");
                    Console.WriteLine("Select Product Id:");
                    int pid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter New Name:");
                    string ptxtname = Console.ReadLine();
                    Console.WriteLine("Enter New Category Id:");
                    int pcategoryid = Convert.ToInt32(Console.ReadLine());
                    Product np = new Product(pid, ptxtname, pcategoryid);
                    db.UpdateTable("product", np);
                    FunctionSelection(db);
                    break;
                case "category":
                    if (db.categorieTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable("product");
                    Console.WriteLine("Select Product Id:");
                    int cid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter New Name:");
                    string ctxtname = Console.ReadLine();
                    Category nc = new Category(cid, ctxtname);
                    db.UpdateTable("product", nc);
                    FunctionSelection(db);
                    break;
                case "accessotion":
                    if (db.accessotionTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable("product");
                    Console.WriteLine("Select Product Id:");
                    int aid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter New Name:");
                    string atxtname = Console.ReadLine();
                    Category na = new Category(aid, atxtname);
                    db.InsertTable("product", na);
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
                    db.SelectTable("product");
                    Console.WriteLine("Select Product Id:");
                    int pid = Convert.ToInt32(Console.ReadLine());
                    db.Delete("product", pid);
                    FunctionSelection(db);
                    break;
                case "category":
                    if (db.categorieTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable("product");
                    Console.WriteLine("Select Product Id:");
                    int cid = Convert.ToInt32(Console.ReadLine());
                    db.Delete("product", cid);
                    FunctionSelection(db);
                    break;
                case "accessotion":
                    if (db.accessotionTable.Count == 0)
                    {
                        Console.WriteLine("There is no data");
                        FunctionSelection(db);
                        break;
                    }
                    db.SelectTable("product");
                    Console.WriteLine("Select Product Id:");
                    int aid = Convert.ToInt32(Console.ReadLine());
                    db.Delete("product", aid);
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
                    db.DeleteAll("product");
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
                    db.DeleteAll("category");
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
                    db.DeleteAll("accessotion");
                    FunctionSelection(db);
                    break;
                default:
                    Console.WriteLine("value does not match");
                    DeleteAll(db);
                    break;
            }
        }

    }
}
