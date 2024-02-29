using System.ComponentModel.DataAnnotations.Schema;

namespace MyPosSystem.Models;

[Table("item")]
public class Item : Product
{
    public int ItemId { get; set; }
    
    [ForeignKey(nameof(Order))]
    public int SaleId { get; set; }
    public Sale? Sale { get; set; }
}