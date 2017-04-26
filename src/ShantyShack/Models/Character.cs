using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShantyShack.Models
{
    [Table("Characters")]
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string Archetype { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Perks Perks { get; set; }
        public virtual ICollection<InventoryItem> InventoryItems { get; set; }
    }
}
