using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoRelationships.Models
{
    [Table("Item")]
    public class Item
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
