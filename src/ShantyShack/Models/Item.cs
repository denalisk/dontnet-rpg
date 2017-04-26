using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShantyShack.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Perks Perks { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
    }
}
