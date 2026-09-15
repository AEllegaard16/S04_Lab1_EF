using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        [Key]
        public int Id { get; set; }

        [StringLength(25, MinimumLength = 5, ErrorMessage = "{0} requires a value between {1} and {2}.")]
        public string Title { get; set; }

        [StringLength(255, MinimumLength = 1, ErrorMessage = "{0} requires a value between {1} and {2}.")]
        public string Description { get; set; }

        [ValidateNever]
        public List<Zombie> Zombies { get; set; }
    }
}
