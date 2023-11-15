using MediatR;
using MediatR.Registration;
using MediatR.Extensions.AttributedBehaviors;
using System.Reflection.Metadata;

namespace Mediator
{

    public record CreateBookingCommand(BookingRequest BookingRequest) : IRequest<BookingResponse>;
    public class BookingCommandHandler : IRequestHandler<CreateBookingCommand, BookingResponse>
    {

        private readonly ILogger<CreateBookingCommand> _logger;

        public BookingCommandHandler(

            ILogger<CreateBookingCommand> logger)
        {

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        public async Task<BookingResponse> Handle(CreateBookingCommand request, CancellationToken cancellationToken)
        {
            List<BookingResponse> responseList = new List<BookingResponse>()
            { new BookingResponse{ Id = new Guid(),
            Name="Title 1"
            , Description ="Description 1"} ,
            new BookingResponse{ Id = new Guid(),
            Name="Title 2"
            , Description ="Description 2"}
            };

            return responseList.Find(x => x.Name == request.BookingRequest.Title);
     
        }

    }
}
