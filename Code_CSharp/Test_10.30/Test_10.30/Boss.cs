﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_10._30
{
    internal sealed class Boss:Enemy
    {
        private int a;
        public sealed override void Move()
        {
            base.a = this.a;
            Test();
        }

        public new void Attack()
        {

        }
    }
}
