using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipTypes MembershipTypes { get; set; }
        public byte MemberShipTypeId { get; set; }
    }
}