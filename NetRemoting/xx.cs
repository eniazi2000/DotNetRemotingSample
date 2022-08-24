using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetRemoting
{
    public class xx: MarshalByRefObject
    {
        public int sum(int a, int b)
        {
            return a + b;
        }
        public string hello(string name)
        {
            return "hello " + name;
        }

    }
}
