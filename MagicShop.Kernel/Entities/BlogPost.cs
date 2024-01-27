using MagicShop.Kernel.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Kernel.Entities
{
    public class BlogPost : CommonProperty
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BlogPostId { get; set; }

        [Required]
        [MaxLength(50)]
        public string BlogPostName { get; set; }

        [Required]
        public string BlogPostContent { get; set; }

        [Required]
        public string BlogPostImage { get; set; }

        [Required]
        public string Slug { get; set; }

        [Required]
        public Guid HoroscopeId { get; set; }

        [ForeignKey(nameof(HoroscopeId))]
        public virtual Horoscope? Horoscope { get; set; }


        public virtual ICollection<Comment> ?Comments { get; set; }

    }
}
