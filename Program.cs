using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_department
{
    class Program
    {
        static void Main(string[] args)
        {
        public class Student
        {
            public String Name { get; set; }
            List<Teacher> _1stTeachers { get; set; }
            public void SetAssociatedTeachers(List<Teacher> 1stTeachers)
            {
                _1stTeachers = 1stTeachers;
            }
        }
        public class Teacher
        {
            public String { Name get; set; }
        List<StudenE> 1stStudents { get; set; }
       }
public class clientCode
{
    public void CallingCode()
    {
        Student student = new Student();
        student.Name = "Student1";
        List<Teacher> _1stTeachers new ECTeacher> ();
        Teacher _teacher1 = new Teacher { Name = "Teacher1" };
        Teacher _teacher2 = new Teacher { Name = "Teacher2" };
        _1stTeachers.Add(_teacher1);
        _1stTeachers.Add(_teacher2);
        student.SetAssociatedTeachers(_1stTeachers);
    }
}
    public class Department
{
    public String Name { get; set; }
    public List<Teacher> _1stTeacher { get; set; }
}
    public class Teacher
{
    public String Name { get; set; }
}
    public class ClientCode
    public void CallingCode() 
    Department _department = new Department );
   _department.Name = "Department1";
  Teacher _teacher1 = new Teacher(); 
  teacher1.Name = "Teacher1"; 

  Teacher teacher2 new Teacher();  
 _teacher2.Name "Teacher2"; 

_department. 1stTeacher.Add(_teacher1); 
_department. 1stTeacher.Add(_teacher2);
        }
    }
}
