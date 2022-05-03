using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocina
{
    public interface IStock
    {
        int Stock { get; set; }

        void AgregarStock(int cantidad);
    }

    
    
}
