using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Dto
{
    public class Firefighter_Action
    {
        [Required]
        public virtual int FirefighterNavigation { get; set; }
        [Required]
        public virtual int ActionNavigation { get; set; }
    }
}
