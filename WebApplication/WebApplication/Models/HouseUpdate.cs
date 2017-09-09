using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class HouseUpdate
    {
        /// <summary>
        /// Color
        /// </summary>
        [Required]
        public string Color { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [MaxLengthAttribute(200)]
        public int NumberOfWindows { get; set; }
    }
}
