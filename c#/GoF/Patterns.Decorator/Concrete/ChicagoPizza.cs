using Patterns.Decorator.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Concrete
{
    public class ChicagoPizza : IPizza
    {
        public decimal Cost()
        {
            return 12m;
        }
    }
}
