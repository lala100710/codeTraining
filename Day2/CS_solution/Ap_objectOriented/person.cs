using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ap_objectOriented
{
    internal class person
    {
        public String id,name;
        //建構函式(建構子)
        public person(String id,String name)
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Id :{0} name:{1}",id,name);
        }
    }
}
