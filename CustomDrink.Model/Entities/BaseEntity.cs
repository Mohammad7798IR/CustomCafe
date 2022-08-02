using System.ComponentModel.DataAnnotations;



namespace CustomDrink.Model.Entities
{
    public class BaseEntity
    {
        [Key]
        public string? Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? UpdatedDate { get; set; }
    }
}
