using System.Runtime.Serialization;

namespace Ecommerce.Domain;

public enum ProductStatus {
    [EnumMember(Value = "Produto Inativo")]
    Inactive,
    [EnumMember(Value = "Produto Ativo")]
    Active
}