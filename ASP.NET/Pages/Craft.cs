using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Models
{
    public class Craft
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public string Creator { get; set; }

        // Additional properties related to your Fitness Tracker theme
        // ...

    }
}

