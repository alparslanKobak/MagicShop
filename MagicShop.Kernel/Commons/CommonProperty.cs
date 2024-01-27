using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Kernel.Commons
{
    public abstract class CommonProperty : ICommonProperty
    {

        public bool IsDeleted { get ; set ; }
    }
}
