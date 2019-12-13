using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemApp_P113.Models
{
   public class Ticket
    {
        public Ticket()
        {
            Commentators = new HashSet<Commentator>();
        }
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        
        [ForeignKey("CreatedUser")]
        public int CreatedBy { get; set; }
        public User CreatedUser { get; set; }

        [Required]
        [StringLength(100,MinimumLength =3)]
        public string Title { get; set; }

        [Required]
        [StringLength(400,MinimumLength =3)]
        public string Description { get; set; }

        [Required]
        public TicketStatus Status { get; set; }


        public DateTime? ClosedDate { get; set; }

        [ForeignKey("ClosedUser")]
        public int? ClosedBy { get; set; }
        public User ClosedUser { get; set; }

        public ICollection<Commentator> Commentators { get; set; }

    }
}
