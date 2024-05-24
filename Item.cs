using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteApi
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}