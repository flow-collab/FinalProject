using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QueueCheckIns.Model
{
    public class CheckIn
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email Address is required")]
        //[MinLength(10, ErrorMessage = "Number should contain ten digits with no spaces")]
        [Display(Name= "Email Address")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Check-In Date")]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckInTime { get; set; }

        public Status? Status { get; set; }

        public Category? Category { get; set; }

        public int CategoryTime { get; set; }

        public int TotalTime { get; set; }

        
    }
}
