using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPosSystem.Models;

[Table("product")]
public abstract class Product
{
    public int ProductId { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, ErrorMessage = "Max lenght: 100 characters")]
    public string Name { get; set; }
    
    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }
    
    [Required(ErrorMessage = "Product price required")]
    public decimal Price { get; set; }
    
    
    
}