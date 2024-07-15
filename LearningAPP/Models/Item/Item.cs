using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LearningAPP.Enums;

namespace LearningAPP.Models;

public class Item
{
    [Column("item_name")]
    public string ItemName { get; set; }

    [Column("item_group")]
    [EnumDataType(typeof(ItemGroup))]
    public ItemGroup ItemGroup { get; set; }

    [Column("unit_of_measurement")]
    [EnumDataType(typeof(UnitOfMeasurement))]
    public UnitOfMeasurement UnitOfMeasurement { get; set; }

    [Column("quantity")]
    public decimal Quantity { get; set; }

    [Column("price_without_vat")]
    public decimal PriceWithoutVat { get; set; }

    [Column("status")]
    public string Status { get; set; }

    [Column("storage_location")]
    public string StorageLocation { get; set; }

    [Column("contact_person")]
    public string ContactPerson { get; set; }

    [Column("photo")]
    public string PhotoPath { get; set; }
    
    public Item(string itemName, ItemGroup itemGroup, UnitOfMeasurement unitOfMeasurement, decimal quantity, decimal priceWithoutVat, string status, string storageLocation, string contactPerson, string photoPath)
    {
        ItemName = itemName;
        ItemGroup = itemGroup;
        UnitOfMeasurement = unitOfMeasurement;
        Quantity = quantity;
        PriceWithoutVat = priceWithoutVat;
        Status = status;
        StorageLocation = storageLocation;
        ContactPerson = contactPerson;
        PhotoPath = photoPath;
    }
    
    
}