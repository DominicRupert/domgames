using System.Collections.Generic;

namespace domgames.Interfaces
{
	public interface IRepository<TItem, TId>
	{
		List<TItem> Get();
		TItem Get(TId id);
	}
}