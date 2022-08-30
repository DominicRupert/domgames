using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domgames.Models;

namespace domgames.Interfaces
{
   public interface IRepoItem<T>
	{
		T Id { get; set; }
		string CreatorId { get; set; }
		Profile Creator { get; set; }
	}
}