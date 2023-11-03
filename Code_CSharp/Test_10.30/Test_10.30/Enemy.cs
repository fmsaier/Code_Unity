using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_10._30
{
    abstract class Enemy : Fly
    {
        protected int a;

        public void Test()
        {

        }

        public abstract void Move();

        public void Attack()
        {

        }
    }
}
