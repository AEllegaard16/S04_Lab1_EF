using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZombieParty.Models
{
    public class Zombie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "{0} requires a value between {1} and {2}.")]
        public string Name { get; set; }

        [Display(Name = "Zombie Type")]
        [ForeignKey("ZombieType")]
        public int ZombieTypeId { get; set; }


        public ZombieType? ZombieType { get; set; }

        [Range(1, 10, ErrorMessage = "{0} requires a value between {1} and {2}.")]
        public int Point { get; set; }

        [StringLength(255, MinimumLength = 1, ErrorMessage = "{0} requires a value between {1} and {2}.")]
        public string ShortDesc { get; set; }
    }
}
