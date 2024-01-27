using MagicShop.Kernel.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicShop.Kernel.Entities
{
    public class Cart : CommonProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CartId { get; set; }
        public virtual ICollection<CartItem>? CardItems { get; set; }

        [Required]
        public Guid AppUserId { get; set; }

        [Required]
        [ForeignKey(nameof(AppUserId))]
        public virtual AppUser? AppUser { get; set; }

    }
}
