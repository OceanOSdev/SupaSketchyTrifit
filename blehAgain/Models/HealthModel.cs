using System;
using System.ComponentModel.DataAnnotations;
namespace blehAgain.Models
{
    public class HealthModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public decimal BMI { get; set; }
    }
}