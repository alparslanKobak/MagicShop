using MagicShop.Kernel.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Kernel.Entities
{
    public class CartItem : CommonProperty
    {
        public Guid CartItemId { get; set; }
        public Guid CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart? Card { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; } = 1;
    }
}
