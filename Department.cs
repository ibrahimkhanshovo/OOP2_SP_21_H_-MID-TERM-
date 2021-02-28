using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {
        private string name;

            public string Name
        {
            get 
            {
                return Name;
            }
            set
            {
                Name = value;
            }
            private string id;
        public string id
        {
            get
            {
                return Value;

            }
            set
            {
                id = value;
            }

            public Department() { }

        public Department (string name, string Id)
         {
            this.name = name;
            this.id = id;
         }

        public void ShowDetails()
             {
            Console.WriteLine("Name : +name");
            nsole.WriteLine("Id : +id");

            }
         }

        }
    }
}
