using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Surfsup_API.Models
{
    [Index(nameof(userId))]
    public class Equipment
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        private int id;
        public int Id { get { return id; } set { id = value; } }

        [Required]
        private int userId;
        public int UserId { get { return userId; } set { userId = value; } }

        [Required]
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private byte[] image;
        public byte[] Image { get { return image; } set { image = value; } }

        [Required]
        private DateTime availableFrom;
        public DateTime AvailableFrom { get { return availableFrom; }
            set
            {
                if (value < AvailableTo && value >= DateTime.UtcNow)
                {
                    availableFrom = value;
                }
            }
        }

        [Required]
        private DateTime availableTo;
        public DateTime AvailableTo { get { return availableTo; } 
            set 
            { 
                if(value > AvailableFrom && value >= DateTime.UtcNow)
                {
                    availableTo = value;
                }
            } 
        }

        [Required]
        private string location;
        public string Location { get { return location; } set { location = value; } }

        private List<Reservation> reservations;
        public List<Reservation> Reservations { get { return reservations; } set { reservations = value; } }
        




    }
}
