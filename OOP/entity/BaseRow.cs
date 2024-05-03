using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.entity
{
    abstract class BaseRow
    {
        protected int id;
        protected string name;

        public virtual int GetId()
        {
            return this.id;
        }

        public virtual string GetName()
        {
            return this.name;
        }

        public virtual void SetId(int id)
        {
            this.id = id;
        }

        public virtual void SetName(string name)
        {
            this.name = name;
        }

        public virtual string TxtData()
        {
            return "Id:" + this.id + " - Name:" + this.name;
        }
    }
}
