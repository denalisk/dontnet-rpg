using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShantyShack.Models
{
    public class InventoryItem
    {
        public int CharacterId { get; set; } 
        public virtual Character Character { get; set; }
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }
    }
}
