using Microsoft.Azure.Cosmos;
using static Mediator.BookingResponse;

namespace Mediator
{
    public class BookingResponse 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

