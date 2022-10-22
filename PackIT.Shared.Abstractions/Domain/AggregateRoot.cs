using System.Collections.Generic;
using System.Linq;

namespace PackIT.Shared.Abstractions.Domain;

public abstract class AggregateRoot<T>
{
	public T Id { get; protected set; }
	public int Version { get; protected set; }
	private readonly List<IDomainEvent> _events = new();
	public IEnumerable<IDomainEvent> Events => _events;
	private bool _isVersionIncremented;

	protected void IncrementVersion()
	{
		if (_isVersionIncremented) return;
		Version++;
		_isVersionIncremented = true;
	}

	protected void AddEvent(IDomainEvent @event)
	{
		if (!_events.Any() && !_isVersionIncremented)
		{
			Version++;
			_isVersionIncremented = true;
		}

		_events.Add(@event);
	}

	public void ClearEvents() => _events.Clear();
}