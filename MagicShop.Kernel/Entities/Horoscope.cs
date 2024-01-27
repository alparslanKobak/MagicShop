using MagicShop.Kernel.Commons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicShop.Kernel.Entities
{
    public class Horoscope : CommonProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid HoroscopeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string HoroscopeName { get; set; }

        [Required]
        [MaxLength(50)]
        public string HoroscopeDescription { get; set; }
        
        public string HoroscopeIcon { get; set; }

        public string HoroscopeImage { get; set; }

        [Required]

        public string Slug { get; set; }

        public virtual ICollection<BlogPost>? BlogPosts { get; set; }


    }
}
