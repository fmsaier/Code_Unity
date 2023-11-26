using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_10._30
{
    internal sealed class Boss:Enemy
    {
        //private new int a;
        public sealed override void Move()
        {
            a = 1;
            Test();
        }

        public new void Attack()
        {

        }
    }
}
