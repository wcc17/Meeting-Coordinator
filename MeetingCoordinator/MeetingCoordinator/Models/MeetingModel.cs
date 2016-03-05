using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingCoordinator.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Title")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long", MinimumLength = 5)]
        public string Title { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Description")]
        public string Descrtiption { get; set; }

        // Should really be an ID pointing to a Room object
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Meeting Room")]
        public string Room { get; set; }

        [Display(Name = "Attendees")]
        public int[] Attendees { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }
    }

    public class MeetingCreateViewModel
    {
        
        public string Title { get; set; }

        
        public string Descrtiption { get; set; }

        // Should really be an ID pointing to a Room object
        
        public string Room { get; set; }

        public int[] Attendees { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
    }

    public class MeetingDbContext : ApplicationDbContext
    {
        public DbSet<Meeting> Meetings { get; set; }
    }
}
