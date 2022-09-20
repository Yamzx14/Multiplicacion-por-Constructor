using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicasion_Constructor
{
    internal class Multiplicaclass
    {
    
        private int n1;
        private int n2;


        
        public Multiplicaclass(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

      
        public int Multi()
        {
            return (n1 * n2);
        }

    }
}
