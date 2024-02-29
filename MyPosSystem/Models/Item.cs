using System.ComponentModel.DataAnnotations.Schema;

namespace MyPosSystem.Models;

[Table("item")]
public class Item : Product
{
    public Guid ItemId { get; set; }
    
    [ForeignKey(nameof(Order))]
    public Guid SaleId { get; set; }
    public Sale? Sale { get; set; }
}