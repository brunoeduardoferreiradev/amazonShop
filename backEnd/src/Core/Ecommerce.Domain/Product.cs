using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain;

public class Product : BaseDomainModel {
    [Column(TypeName = "NVARCHAR(100)")]
    public string? Name{get; set;}

    [Column(TypeName = "decimal(10,2)")]
    public decimal Price {get; set;}

    [Column(TypeName = "NVARCHAR(4000)")]
    public string? Description {get; set;}

    public int Rating {get; set;}

    [Column(TypeName = "NVARCHAR(100)")]
    public string? Seller {get; set;}

    public int Stock {get; set;}

    public ProductStatus Status {get; set;} = ProductStatus.Active;

    public int CategoryId {get; set;}
}