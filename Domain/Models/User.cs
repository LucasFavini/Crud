using System.ComponentModel.DataAnnotations;

namespace plu.Models
{
    public class User
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        [Required]

        public string email { get; set; }
        [Required]

        public string password { get; set; }

    }
}
