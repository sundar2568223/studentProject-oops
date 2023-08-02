//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Collections.Specialized.BitVector32;
//using System.Xml.Linq;

//namespace ClassLibrary1
//{
//    public class student
//    {
//        public string name;
//        public int classs;
//        public char section;

//        public virtual void gets()
//        {
//            Console.WriteLine("Provide the students details :");
//            Console.WriteLine("Enter the student name");
//            name = Console.ReadLine();
//            Console.WriteLine("enter the class");
//            classs = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter the section");
//            section = Convert.ToChar(Console.ReadLine());
//        }
//        public virtual void prints()
//        {
//            Console.WriteLine("print the student details");
//            Console.WriteLine(name);
//            Console.WriteLine(classs);
//            Console.WriteLine(section);
//        }
//    }
//    public class teacher : student
//    {
//        public string subject;
//        public override void gets()
//        {
//            Console.WriteLine("enter the teacher details");
//            Console.WriteLine("enter the teacher name");
//            name = Console.ReadLine();
//            Console.WriteLine("enter the class");
//            classs = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("enter the section");
//            section = Convert.ToChar(Console.ReadLine());
//            Console.WriteLine("enter the subject");
//            subject = Console.ReadLine();
//        }
//        public override void prints()
//        {
//            Console.WriteLine("print the Teacher details");
//            Console.WriteLine(name);
//            Console.WriteLine(classs);
//            Console.WriteLine(section);
//            Console.WriteLine(subject);
//        }
//    }
//    public class subject : student
//    {
//        public string subject_code;
//        public override void gets()
//        {
//            Console.WriteLine("enter the subject details");
//            Console.WriteLine("-------------------");
//            Console.WriteLine("enter the subject name");
//            name = Console.ReadLine();
//            Console.WriteLine("enter the subject code");
//            subject_code = Console.ReadLine();

//        }
//        public override void prints()
//        {
//            Console.WriteLine("print the student details");
//            Console.WriteLine("student" + name);
//            Console.WriteLine(subject_code);

//        }
//    }

//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class student
    {
        public string name;
        public int clas;
        public char sec;

        public virtual void gettingdetails()
        {
            Console.WriteLine("*****Enter the student details****");
            Console.WriteLine("Enter the student name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the student class ");
            clas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the student section");
            sec = Convert.ToChar(Console.ReadLine());
        }
        public virtual void printthedetails()
        {
            Console.WriteLine("****Getting and printing  the student details***");
            Console.WriteLine(name);
            Console.WriteLine(clas);
            Console.WriteLine(sec);
        }
    }
    public class teacher : student
    {
        public string subject;
        public override void gettingdetails()
        {
            Console.WriteLine("****enter the belong  teacher details of the student****");
            Console.WriteLine("Enter the class teacher name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the class as integer ");
            clas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the section as character");
            sec = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the subject name:");
            subject = Console.ReadLine();
        }
        public override void printthedetails()
        {
            
            Console.WriteLine("***printing  the teacher details****");
            Console.WriteLine(name);
            Console.WriteLine(clas);
            Console.WriteLine(sec);
            Console.WriteLine(subject);
        }
    }
    public class subject : student
    {
        public string subcode;
        public override void gettingdetails()
        {
            Console.WriteLine("Enter the subject details");
            Console.WriteLine("Enter the subject name in string");
            name = Console.ReadLine();
            Console.WriteLine("Enter the subject code as string ");
            subcode = Console.ReadLine();

        }
        public override void printthedetails()
        {
            Console.WriteLine("print the student details");
            Console.WriteLine(name);
            Console.WriteLine(subcode);
            Console.ReadLine();

        }
    }

}