using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class HouseCreate
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
        public string Address { get; set; }

        /// <summary>
        /// Number of windows
        /// </summary>
        public int NumberOfWindows { get; set; }
    }
}
