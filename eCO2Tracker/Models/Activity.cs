using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCO2Tracker.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Units { get; set; }
        public Category Category { get; set; }
        public bool IsPerformed { get; set; }

    }
}
