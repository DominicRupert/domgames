using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domgames.Interfaces;

namespace domgames.Models
{
    public class Game : IRepoItem<int>
    {
        public int Id { get; set; }
        public string CreatorId { get; set; }
        public Profile Creator { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Platform { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        
        
    }
}