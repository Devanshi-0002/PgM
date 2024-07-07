using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CityHome.Addresses
{
    public class CreateUpdateAddressDto
    {
        [Required]
        [StringLength(200)]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required]
        [StringLength(10)]
        public string Pincode { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }
    }
}
