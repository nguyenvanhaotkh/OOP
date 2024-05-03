using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.entity
{
    class Accessotion
    {
        public int id;
        public string name;
        public Accessotion() { }
        public Accessotion(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string TxtData()
        {
            return "Id:" + this.id + " - Name:" + this.name;
        }
    }
}
