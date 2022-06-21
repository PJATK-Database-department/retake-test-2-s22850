using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApbdTest2.Responses
{
    public class UpdateActionRequest
    {
        [Required]
        public int IdAction { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool NeedSpecialEquipment { get; set; }
      
    }
}
