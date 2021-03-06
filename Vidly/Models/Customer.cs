﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        
        public MembershipType MembershipType { get; set; } // This is a navigation property

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }// EF recognizes this convention and treats this as a foriegn key
    }
}