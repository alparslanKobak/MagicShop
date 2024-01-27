using MagicShop.Kernel.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicShop.Kernel.Entities
{
    public class Category : CommonProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CategoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }

        [Required]
        public string Slug { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
