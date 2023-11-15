using MediatR;
using MediatR.Registration;
using MediatR.Extensions.AttributedBehaviors;
using System.Reflection.Metadata;

namespace Mediator
{
    public record GetBookingByIdQuery(Guid Id) : IRequest<BookingResponse>;
    public class BookingQueryHandler : IRequestHandler<GetBookingByIdQuery, BookingResponse>
    {

        private readonly ILogger<CreateBookingCommand> _logger;

        public BookingQueryHandler(

            ILogger<CreateBookingCommand> logger)
        {

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        public async Task<BookingResponse?> Handle(GetBookingByIdQuery request, CancellationToken cancellationToken)
        {
            List<BookingResponse> responseList = new List<BookingResponse>()
            { new BookingResponse{ Id = new Guid(),
            Name="Title 1"
            , Description ="Description 1"} ,
            new BookingResponse{ Id = new Guid(),
            Name="Title 2"
            , Description ="Description 2"}
            };

            return responseList.Find(x => x.Name == request.Id.ToString());
        }

    }
}
