using System;
using System.ComponentModel.DataAnnotations;

namespace eShop.Domain.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

