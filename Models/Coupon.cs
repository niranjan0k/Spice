﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        
        [Required]
        [Display(Name ="Coupon Type")]
        public string CouponType { get; set; }
        
        public enum ECouponType
        {
            Percent = 0, Rupee = 1
        }

        [Required]
        public double Discount { get; set; }

        [Required]
        [Display(Name = "Minimum Amount")]
        public double MinimumAmount { get; set; }

        public byte[] Picture { get; set; }

        public bool IsActive { get; set; }

    }
}
