﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Projet_2022.Data.Repository;

namespace Projet_2022.Models.Entities
{
    public class User :IdentityUser,IEntityBase
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zipcode { get; set; }
        [Required]
        public bool EmailVerification { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime RegistrationDate { get; set; }
        public virtual List<Order> Orders { get; set; }
        
    }
}
