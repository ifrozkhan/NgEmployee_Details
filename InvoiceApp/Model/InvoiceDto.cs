using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InvoiceApp.Model
{
    public class InvoiceDto
    {
        [Required]
        public string Number { get; set; } = "";
        [Required]
        public string Status { get; set; } = "";
        public DateOnly? IssueDate { get; set; }
        public DateOnly? DueDate { get; set; }


        //Service Details
        [Required]
        public string Service { get; set; } = "";
        [Range(1, 999999, ErrorMessage ="Unit Price is not valid")]
        public decimal UintPrice { get; set; }
        [Range(1, 99)]
        public int Quamtity { get; set; }


        //Client details
        [Required(ErrorMessage ="Client name is required")]
        public string Clientname { get; set; } = "";
        [Required,EmailAddress]
        public string Email { get; set; } = "";
        [Phone]
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
