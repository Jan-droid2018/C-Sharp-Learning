using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes lasagne");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }
    }
}
