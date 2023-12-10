using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12practice
{
    public class Program
    {
        static void Main()
        {
            MyClass myObject = new MyClass();
            myObject.PropertyChanged += MyObject_PropertyChanged;
            myObject.MyProperty = 42;
            Console.ReadKey();
        }
        private static void MyObject_PropertyChanged(object sender, PropertyEventArgs e)
        {
            Console.WriteLine($"Собственность '{e.PropertyName}' измененный.");
        }
    }
}
