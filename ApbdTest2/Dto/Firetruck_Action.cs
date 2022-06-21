using System;
using System.ComponentModel.DataAnnotations;

namespace ApbdTest2.Dto
{
    public class Firetruck_Action
    {
        [Required]
        public int IdFireTruckAction { get; set; }
        public virtual int FiretruckNavigation { get; set; }
        public virtual int ActionNavigation { get; set; }
        public DateTime AssignmentDate { get; set; }
    }
}