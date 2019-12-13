using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketSystemApp_P113.Models
{
   public class Commentator
    {
        public int Id { get; set; }

        [Required]
        public DateTime CommentDate { get; set; }

        [ForeignKey("CommentedUser")]
        public int CommentedBy { get; set; }
        public User CommentedUser { get; set; }

        [Required]
        [StringLength(500,MinimumLength =3)]
        public string Desciption { get; set; }
    }
}
