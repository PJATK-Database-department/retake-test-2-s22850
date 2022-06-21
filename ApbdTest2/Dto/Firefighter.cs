using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Dto
{
    public class Firefighter
    {
        [Required]
        public int IdFirefighter { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }

        public ICollection<Firefighter_Action> firefighter_Actions { get; set; }

    }
}
