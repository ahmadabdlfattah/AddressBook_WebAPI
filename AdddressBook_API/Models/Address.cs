using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class Address
    {

        public int Id { get; set; }

        [Required]
        public string GUId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string PhysicalAddress { get; set; }

        public string PhoneNumber { get; set; }
        [DataType(DataType.PhoneNumber)]

        public string JobPosition { get; set; }

        public string Institution { get; set; }
       
    }
}