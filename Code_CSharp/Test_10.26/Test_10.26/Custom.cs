using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_10._26
{
    internal class Custom
    {
        private int age;
        private string name;


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

        public string Name
        {
            get;set;
        }

        public bool Sex { get; set; }
    }
}
