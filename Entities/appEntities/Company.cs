using System.ComponentModel.DataAnnotations;

namespace projeApi.Entities.appEntities
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}