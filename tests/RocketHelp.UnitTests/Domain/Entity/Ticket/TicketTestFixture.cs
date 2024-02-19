using RocketHelp.UnitTests.Common;

namespace RocketHelp.UnitTests.Domain.Entity.Ticket;

public class TicketTestFixture : BaseFixture
{
    public TicketTestFixture() : base() { }

}


[CollectionDefinition(nameof(TicketTestFixture))]
public class TicketTestFixtureColletion : ICollectionFixture<TicketTestFixture>
{

}