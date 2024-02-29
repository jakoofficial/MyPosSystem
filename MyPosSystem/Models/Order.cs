using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPosSystem.Models;

[Table("order")]

public class Order
{
    public Guid OrderId { get; set; }
    
    public bool IsComplete { get; set; }
    
    [Required(ErrorMessage = "Order needs a date and time")]
    public DateTime Date { get; set; }
    
    public ICollection<Sale>? Sales { get; set; }
}