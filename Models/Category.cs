using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoRelationships.Models
{
    [Table("Category")]
    public class Category
    {
        public Category()
        {
            this.Items = new HashSet<Item>();
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
