using Microsoft.EntityFrameworkCore;

namespace InvoiceApp.Model
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Number { get; set; } = "";
        public string Status { get; set; } = "";
        public DateOnly? IssueDate { get; set; }
        public DateOnly? DueDate { get; set; }

        //Service Details
        public string Service { get; set; } = "";
        [Precision(16, 2)]
        public decimal UintPrice { get; set; }
        public int Quamtity { get; set; }

        //Client details
        public string Clientname { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
