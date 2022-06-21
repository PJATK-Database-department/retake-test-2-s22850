using ApbdTest2.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Responses
{
    public class GetFiretruckResponse
    {
        [Required]
        public int IdFiretruck { get; set; }
        [Required]
        [MaxLength(10)]
        public string OperationalNumber { get; set; }
        [Required]
        public bool SpecialEquipment { get; set; }
        [Required]
        public ICollection<Firetruck_Action> firetruck_Actions { get; set; }
    }
}
