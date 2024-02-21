using RocketHelp.Domain.SeedWork;

namespace RocketHelp.Domain.Repository.SearchableRepository;

public interface ISearchableRepository<TAggregate>
    where TAggregate : AggregateRoot
{
    Task<SearchOutput<TAggregate>> Search(
        SearchInput input,
        CancellationToken cancellationToken
    );
}
