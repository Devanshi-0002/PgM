using CityHome.Addresses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CityHome.Pgs
{
    public class CreateUpdatePgDto
    {
        [Required]
        [StringLength(100)]
        public string PgName { get; set; }

        [Required]
        public int Vacancy { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        [StringLength(100)]
        public string OwnerName { get; set; }

        [Required]
        [StringLength(200)]
        public string PgAddress { get; set; }

        [Required]
        [StringLength(15)]
        public string OwnerPhoneNumber { get; set; }

        [Required]
        public decimal PgRent { get; set; }

        [Required]
        public DateTime PgOpeningDate { get; set; }
    }
}
