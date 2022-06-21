using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Dto
{
    public class Firetruck
    {
        [Required]
        public int IdFiretruck { get; set; }
        [MaxLength(10)]
        public string OperationalNumber { get; set; }
        public bool SpecialEquipment { get; set; }
        public ICollection<Firetruck_Action> firetruck_Actions { get; set; }
    }
}
