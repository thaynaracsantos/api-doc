using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class House
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Number of windows
        /// </summary>
        public int NumberOfWindows { get; set; }
    }
}
