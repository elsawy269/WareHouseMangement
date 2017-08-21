using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseMangement.Data.Entities
{
    public class Group:BaseEntity
    {
        public ICollection<Item> Items { get; set; }
    }
}
