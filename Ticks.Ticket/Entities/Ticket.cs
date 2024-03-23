using System.ComponentModel.DataAnnotations;
using Ticks.Tickets.Enums;

namespace Ticks.Tickets.Entities
{
    public class Ticket
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long MerchantId { get; set; }

        [Required]
        public string EventName { get; set; }

        public DateTime SalesDeadlineDate { get; set; }

        public TicketType TicketType { get; set; }

        public double Price { get; set; }

        public DateTime CreatedAt { get; set; } 

        public DateTime UpdatedAt { get; set;}

    }
}
