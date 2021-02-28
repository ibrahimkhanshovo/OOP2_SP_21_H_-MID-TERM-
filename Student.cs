using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        private string name;

        public string name
        {
            get { return name; }
            set { name = value; }
        }

        private string Id;

            public string id
        {
            get { return id; }
            set { Id = value; }
        }

        private float cgpa;

        public float cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        Department department;
        public Department Department
        {
            get { return department; }
            set { depatment = value; }
        }
        public Student() { }

        public Student(string name, string id,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;

        }

        public void showDetails()
        {
            Console.WriteLine("Name : "+ name);
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Cgpa : " + cgpa);
        }

    }
}
