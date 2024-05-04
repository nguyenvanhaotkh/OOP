using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.demo
{
    class AccessotionDemo
    {
        public Accessotion CreateProductTest(int id, string name)
        {
            return new Accessotion(id, name);
        }
        public void PrintProduct(Accessotion accessotion)
        {
            Console.WriteLine(accessotion.TxtData());
        }
    }
}
