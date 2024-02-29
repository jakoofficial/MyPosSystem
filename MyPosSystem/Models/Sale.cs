using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyPosSystem.Models;

namespace MyPosSystem.Models;

[Table("sale")]
public class Sale
{
    public int SaleId { get; set; }
    
    [Required(ErrorMessage = "A sale needs a quantity")]
    [MinLength(1, ErrorMessage = "Quantity can't be 0 or lower")]
    public int Quantity { get; set; }    
    
    [Required(ErrorMessage = "A product requires an item")]
    public ICollection<Item>? Items { get; set; }
    
    [ForeignKey(nameof(Order))]
    public Guid OrderId { get; set; }
    public Order? Order { get; set; }
}