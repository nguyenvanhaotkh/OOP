using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.dao;
using OOP.entity;
using OOP.demo;

namespace OOP
{
    class Program
    {
        const string PRODUCT = "product";
        const string CATEGORY = "category";
        const string ACCESSOTION = "accessotion";

        private ProductDaoDemo productDaoDemo = new ProductDaoDemo(new ProductDemo(),new ProductDAO());
        private CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo(new CategoryDAO());
        private AccessoryDAODemo accessoryDaoDemo = new AccessoryDAODemo(new AccessoryDAO());
        static void Main(string[] args)
        {
            //Database db = Database.GetInstance();
            Program p = new Program();
            p.TestProduct();
        }
        private void TestProduct()
        {
            productDaoDemo.Test();
        }
        #region a
        //private void FunctionSelection()
        //{
        //    Console.WriteLine("1-Insert");
        //    Console.WriteLine("2-Select");
        //    Console.WriteLine("3-Update");
        //    Console.WriteLine("4-Delete");
        //    Console.WriteLine("5-Delete All");
        //    Console.WriteLine("6-Find By Id");
        //    Console.WriteLine("7-Exit");
        //    int iselect = Convert.ToInt32(Console.ReadLine());
        //    switch (iselect)
        //    {
        //        case 1:
        //            Insert();
        //            break;
        //        case 2:
        //            Select();
        //            break;
        //        case 3:
        //            Update();
        //            break;
        //        case 4:
        //            Delete();
        //            break;
        //        case 5:
        //            DeleteAll();
        //            break;
        //        case 6:
        //            FindById();
        //            break;
        //        case 7:
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.WriteLine("value does not match");
        //            FunctionSelection();
        //            break;

        //    }
        //}

        //private void Insert()
        //{
        //    Console.WriteLine("Enter Entity:");
        //    string txt = Console.ReadLine();
        //    if (txt == PRODUCT) {
        //        Product np = (Product)ObjectFormInput(txt);
        //        DatabaseDemo.GetInstance().InsertTableTest(PRODUCT, np);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == CATEGORY) {
        //        Category nc = (Category)ObjectFormInput(txt);
        //        DatabaseDemo.GetInstance().InsertTableTest(CATEGORY, nc);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == ACCESSOTION) {
        //        Accessotion na = (Accessotion)ObjectFormInput(txt);
        //        DatabaseDemo.GetInstance().InsertTableTest(ACCESSOTION, na);
        //        FunctionSelection();
        //        return;
        //    }
        //    Console.WriteLine("value does not match");
        //    Insert();
        //}

        //private void Select()
        //{
        //    Console.WriteLine("Enter Entity:");
        //    string txt = Console.ReadLine();
        //    if (txt == PRODUCT)
        //    {
        //        if (Database.GetInstance().productTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(PRODUCT);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == CATEGORY)
        //    {
        //        if (Database.GetInstance().categorieTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(CATEGORY);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == ACCESSOTION)
        //    {
        //        if (Database.GetInstance().accessotionTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(ACCESSOTION);
        //        FunctionSelection();
        //        return;
        //    }
        //    Console.WriteLine("value does not match");
        //    Select();
        //}

        //private void Update()
        //{
        //    Console.WriteLine("Enter Entity:");
        //    string txt = Console.ReadLine();
        //    if (txt == PRODUCT)
        //    {
        //        if (Database.GetInstance().productTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(PRODUCT);
        //        int productId = InputId();
        //        if (!CheckId(txt, productId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        Product newProduct = (Product)ObjectFormInput(txt);
        //        newProduct.SetId(productId);
        //        DatabaseDemo.GetInstance().UpdateTableTest(PRODUCT, newProduct);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == CATEGORY)
        //    {
        //        if (Database.GetInstance().categorieTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(CATEGORY);
        //        int categoryId = InputId();
        //        if (!CheckId(txt, categoryId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        Category newCategory = (Category)ObjectFormInput(txt);
        //        newCategory.SetId(categoryId);
        //        DatabaseDemo.GetInstance().UpdateTableTest(CATEGORY, newCategory);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == ACCESSOTION)
        //    {
        //        if (Database.GetInstance().accessotionTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(ACCESSOTION);
        //        int accessotionId = InputId();
        //        if (!CheckId(txt, accessotionId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        Accessotion newAccessotion = (Accessotion)ObjectFormInput(txt);
        //        newAccessotion.SetId(accessotionId);
        //        DatabaseDemo.GetInstance().UpdateTableTest(ACCESSOTION, newAccessotion);
        //        FunctionSelection();
        //        return;
        //    }
        //    Console.WriteLine("value does not match");
        //    Update();
        //}

        //private void Delete()
        //{
        //    Console.WriteLine("Enter Entity:");
        //    string txt = Console.ReadLine();
        //    if (txt == PRODUCT)
        //    {
        //        if (Database.GetInstance().productTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(PRODUCT);
        //        int productId = InputId();
        //        if (!CheckId(txt, productId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().DeleteTest(PRODUCT, productId);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == CATEGORY)
        //    {
        //        if (Database.GetInstance().categorieTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(CATEGORY);
        //        int categoryId = InputId();
        //        if (!CheckId(txt, categoryId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().DeleteTest(CATEGORY, categoryId);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == ACCESSOTION)
        //    {
        //        if (Database.GetInstance().accessotionTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(ACCESSOTION);
        //        int accessotionId = InputId();
        //        if (!CheckId(txt, accessotionId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().DeleteTest(ACCESSOTION, accessotionId);
        //        FunctionSelection();
        //        return;
        //    }
        //    Console.WriteLine("value does not match");
        //    Delete();
        //}

        //private void DeleteAll()
        //{
        //    Console.WriteLine("Enter Entity:");
        //    string txt = Console.ReadLine();
        //    if (txt == PRODUCT)
        //    {
        //        if (Database.GetInstance().productTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().DeleteAllTest(PRODUCT);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == CATEGORY)
        //    {
        //        if (Database.GetInstance().categorieTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().DeleteAllTest(CATEGORY);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == ACCESSOTION)
        //    {
        //        if (Database.GetInstance().accessotionTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().DeleteAllTest(ACCESSOTION);
        //        FunctionSelection();
        //        return;
        //    }
        //    Console.WriteLine("value does not match");
        //    DeleteAll();
        //}

        //private void FindById()
        //{
        //    Console.WriteLine("Enter Entity:");
        //    string txt = Console.ReadLine();
        //    if (txt == PRODUCT)
        //    {
        //        if (Database.GetInstance().productTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(PRODUCT);
        //        int productId = InputId();
        //        if (!CheckId(txt, productId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().FindByIdTest(PRODUCT, productId);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == CATEGORY)
        //    {
        //        if (Database.GetInstance().categorieTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(CATEGORY);
        //        int categoryId = InputId();
        //        if (!CheckId(txt, categoryId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().FindByIdTest(CATEGORY, categoryId);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == ACCESSOTION)
        //    {
        //        if (Database.GetInstance().accessotionTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(ACCESSOTION);
        //        int accessotionId = InputId();
        //        if (!CheckId(txt, accessotionId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().FindByIdTest(ACCESSOTION, accessotionId);
        //        FunctionSelection();
        //        return;
        //    }
        //    Console.WriteLine("value does not match");
        //    Delete();
        //}

        //private void FindByName()
        //{
        //    Console.WriteLine("Enter Entity:");
        //    string txt = Console.ReadLine();
        //    if (txt == PRODUCT)
        //    {
        //        if (Database.GetInstance().productTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(PRODUCT);
        //        int productId = InputId();
        //        if (!CheckId(txt, productId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().FindByIdTest(PRODUCT, productId);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == CATEGORY)
        //    {
        //        if (Database.GetInstance().categorieTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(CATEGORY);
        //        int categoryId = InputId();
        //        if (!CheckId(txt, categoryId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().FindByIdTest(CATEGORY, categoryId);
        //        FunctionSelection();
        //        return;
        //    }
        //    if (txt == ACCESSOTION)
        //    {
        //        if (Database.GetInstance().accessotionTable.Count == 0)
        //        {
        //            Console.WriteLine("There is no data");
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().SelectTableTest(ACCESSOTION);
        //        int accessotionId = InputId();
        //        if (!CheckId(txt, accessotionId))
        //        {
        //            FunctionSelection();
        //            return;
        //        }
        //        DatabaseDemo.GetInstance().FindByIdTest(ACCESSOTION, accessotionId);
        //        FunctionSelection();
        //        return;
        //    }
        //    Console.WriteLine("value does not match");
        //    Delete();
        //}

        //private object ObjectFormInput(string name)
        //{
        //    if(name == PRODUCT)
        //    {
        //        int productId = Database.GetInstance().productTable.Count();
        //        Console.WriteLine("Enter New Name:");
        //        string productName = Console.ReadLine();
        //        Console.WriteLine("Enter New Category Id:");
        //        int productCategoryId = Convert.ToInt32(Console.ReadLine());
        //        return new Product(productId,productName, productCategoryId);
        //    }
        //    if(name == CATEGORY)
        //    {
        //        int categoryId = Database.GetInstance().categorieTable.Count();
        //        Console.WriteLine("Enter New Name:");
        //        string categoryName = Console.ReadLine();
        //        return new Category(categoryId, categoryName);
        //    }
        //    int accessotionId = Database.GetInstance().accessotionTable.Count();
        //    Console.WriteLine("Enter New Name:");
        //    string accessotionName = Console.ReadLine();
        //    return new Accessotion(accessotionId, accessotionName);
        //}

        //private int InputId()
        //{
        //    Console.WriteLine("Select Id:");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    return id;
        //}

        //private bool CheckId(string name, int id)
        //{
        //    if (name == PRODUCT && Database.GetInstance().productTable.FirstOrDefault(productObject => productObject.GetId() == id) != null)
        //    {
        //        return true;
        //    }
        //    if (name == CATEGORY && Database.GetInstance().categorieTable.FirstOrDefault(categoryObject => categoryObject.GetId() == id) != null)
        //    {
        //        return true;
        //    }
        //    if (name == ACCESSOTION && Database.GetInstance().accessotionTable.FirstOrDefault(accessotionObject => accessotionObject.GetId() != id) == null)
        //    {
        //        return true;
        //    }
        //    Console.WriteLine("id does not exist");
        //    return false;
        //}
        #endregion
    }
}
