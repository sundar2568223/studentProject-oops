//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;
//using ClassLibrary1;

//namespace OopsProject
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            student s = new student();
//            s.gets();
//            s.prints();
//            s = new teacher();
//            s.gets();
//            s.prints();
//            s = new subject();
//            s.gets();
//            s.prints();

//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibrary1;

namespace oopsproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student stu = new student();
            stu.gettingdetails();
            stu.printthedetails();
            stu = new teacher();
            stu.gettingdetails();
            stu.printthedetails();
            stu = new subject();
            stu.gettingdetails();
            stu.printthedetails();

        }
    }
}