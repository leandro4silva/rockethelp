using RocketHelp.UnitTests.Common;

namespace RocketHelp.UnitTests.Domain.Entity.Ticket;


[Collection(nameof(TicketTestFixture))]
public class TicketTest : BaseFixture
{
    private readonly TicketTestFixture _fixture;

    public TicketTest(TicketTestFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact(DisplayName = nameof(Instantiate))]
    [Trait("Domain", "Ticket - Aggregates")]
    public void Instantiate()
    {

    }
}
