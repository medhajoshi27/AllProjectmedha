using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg6
{
    class Student
    {
        private string code = "N.A";
        private string name = "not known";
        private int age = 0;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return "Code =" + Code + ",Name =" + Name + ", Age=" + Age;
        }
    }
    public class ExampleDemo
    {  
        static void Main(string[] args)
        {
        Student s = new Student();
        s.Code = "001";
        s.Name = "Zara";
        s.Age=21;
        Console.WriteLine("student info{0}", s);
    
    s.Age += 1;
         Console.WriteLine("Student Info: {0}", s);
         Console.ReadKey();
      }
    }
}
