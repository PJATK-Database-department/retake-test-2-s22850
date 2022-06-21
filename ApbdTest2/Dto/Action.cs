using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Dto
{
    public class Action
    {
        [Required]
        public int IdAction { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool NeedSpecialEquipment { get; set; }
        public ICollection<Firefighter_Action> firefighter_Actions { get; set; }

        public ICollection<Firetruck_Action> firetruck_Actions { get; set; }
    }
}
