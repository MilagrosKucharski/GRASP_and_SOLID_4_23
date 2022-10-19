using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID;

public class Catalog
{
    public static readonly List<Product> productCatalog = new();
    public static readonly List<Equipment> equipmentCatalog = new();
    public static readonly Catalog Instance = new();

    private Catalog()
    { }

    public void AddProductToCatalog(string description, double unitCost)
        {
            productCatalog.Add(new Product(description, unitCost));
        }

        public void AddEquipmentToCatalog(string description, double hourlyCost)
        {
            equipmentCatalog.Add(new Equipment(description, hourlyCost));
        }

        public Product ProductAt(int index)
        {
            return productCatalog[index] as Product;
        }

        public Equipment EquipmentAt(int index)
        {
            return equipmentCatalog[index] as Equipment;
        }

        public Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }

        public Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }

}