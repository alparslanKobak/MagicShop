using MagicShop.Kernel.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicShop.Kernel.Entities
{
    public class Contact : CommonProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ContactId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ContactName { get; set; }

        [Required]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string ContactEmail { get; set; }

        [Required]
        [MaxLength(50)]
        public string ContactSubject { get; set; }

        [Required]
        public string ContactMessage { get; set; }

        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
