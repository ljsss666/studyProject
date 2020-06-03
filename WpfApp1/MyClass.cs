using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApp1
{
   

    public class MyClass
    {

        private List<Class1> persons { get; set; }
        public MyClass() {
            persons = new List<Class1>();
            persons.Add(new Class1 {name="sss",age=18 });
            persons.Add(new Class1 { name = "aaa", age = 19 });

        }

   
    }

   
}
