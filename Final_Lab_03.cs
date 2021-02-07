using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Lab._03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Account
    {
        class Account1
        {
            private string accName;
            private string acid;
            private int balance;
            int amount;

            public Account1()
            {

            }
            public string AccName
            {
                get
                {
                    return accName;
                }
                set
                {
                    accName = value;
                }
            }
            public string Acid
            {
                get
                {
                    return acid;
                }
                set
                {
                    acid = value;
                }
            }
            public int Balance
            {
                get
                {
                    return balance;
                }
                set
                {
                    balance = value;
                }
            }
            public int Amount
            {
                get
                {
                    return amount;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Please enter your amount:");
                    }
                    else
                    {
                        amount = value;
                    }
                }
            }

            class Main1
            {
                public void Main(string[] args)
                {
                    Account1 a = new Account1();
                    a.accName = "Rahim Ahmed";
                    a.acid = "Rahim01";
                    a.balance = 434544;
                    Console.WriteLine("Deposit: " balance += amount);
                    Console.WriteLine("Withdrawal: " balance += amount);
                }

            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course0
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;

        public Course()
        {
        }

        public Course(string courseName, string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                courseName = value;
            }
        }

        public string CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                courseCode = value;
            }
        }

        public int CourseCredit
        {
            get
            {
                return courseCredit;
            }
            set
            {
                courseCredit = value;
            }
        }

        class System
        {
            static void Main(string[] args)
            {
                Course c = new Course();
                c.courseName = "COA";
                c.courseCode = "UWE5678";
                c.courseCredit = 3;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Student 
{ private string name;
    private string id;
    private string department;
    private float cgpa; 
    public Student() { }
    public string Name 
   get
{ return name; }
  set
{ name = value; } } 
public string ID 
get 
{ return id; }
set 
{ id = value; } } 
public string Department 
{ get 
 { return department; }
 set { department = value; }
public float CG
public string Department 
{ get 
    { return department; } 
    set { department } value; }
public float CG 
{ get 
    { return cgpa; } 
    set
    { cgpa = value; } }
public void showinfo()
{
    Console.Writeline("NAME :" + Name);
    Console.Writeline" +"("ID: " + ID);
    Console.Writeline("DEPARTMENT: " + Department);
    Console.Writeline("CGPA: " + CG);
class Program 
    static void Main(string[] args) 
{ Student s = new Student(); 
    s.Name = "Ovywankenobi"; 
    s.ID = "38779"; 
    s.Department = "CSE"; 
    s.CG = 0.1F;
    s.showinfo();