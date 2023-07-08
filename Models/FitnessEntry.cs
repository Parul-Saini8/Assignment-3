using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Models
{
    public class FitnessEntry
    {
        public int ID { get; set; }
        public string ActivityName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public int DurationInMinutes { get; set; }
        public int CaloriesBurned { get; set; }
        public string Notes { get; set; }
        public string Location { get; set; }
        public string WeatherCondition { get; set; }
        public string GearUsed { get; set; }
        
    }
}


