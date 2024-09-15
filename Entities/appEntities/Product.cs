using System.ComponentModel.DataAnnotations;

namespace projeApi.Entities.appEntities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
    }
}