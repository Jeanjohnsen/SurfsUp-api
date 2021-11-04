using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Surfsup_API.Models
{
    public class Reservation
    {
        [Required]
        private int id;
        public int Id { get; set; }

        [Required]
        [ForeignKey("equipmentFK")]
        private int equipmentId;
        public int EquipmentId { get { return equipmentId; } set { equipmentId = value; } }

        [Required]
        private int userId;
        public int UserId { get { return userId; } set { userId = value; } }

        [Required]
        private DateTime reservedFrom;
        public DateTime ReservedFrom { get { return reservedFrom; }
            set
            {
                if (value < ReservedTo && value >= DateTime.UtcNow)
                {
                    reservedFrom = value;
                }
            }
        }

        [Required]
        private DateTime reservedTo;
        public DateTime ReservedTo { get { return reservedTo; }
            set
            {
                if (value > ReservedFrom && value >= DateTime.UtcNow)
                {
                    reservedTo = value;
                }
            }
        }

    }
}
