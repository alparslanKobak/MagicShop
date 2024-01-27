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
    public class Comment : CommonProperty
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CommentId { get; set; }

        public Guid BlogPostId { get; set; }

        public Guid AppUserId { get; set; }

        [MaxLength(500)]
        public string? CommentContent { get; set; }

        public DateTime CreateDate { get; set; }

        [ForeignKey(nameof(BlogPostId))]
        public BlogPost? BlogPost { get; set; }

        [ForeignKey(nameof(AppUserId))]
        public AppUser? AppUser { get; set; }




    }
}
