

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        // TODO: Update the item's price with the new price.
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        QuantityInStock -= quantitySold;
        if (QuantityInStock < 0)
        {
            QuantityInStock = 0;
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"Item Name: {ItemName}");
        Console.WriteLine($"Item Id: {ItemId}");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Quantity In Stock: {QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:

        //Update the price of the item
        Console.WriteLine("Update price of item1:");
        item1.UpdatePrice(1000.25);
        item1.PrintDetails();
        Console.WriteLine();

        // 1. Print details of all items.
        Console.WriteLine("All items:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();

        // 2. Sell some items and then print the updated details.
        Console.WriteLine("Item sold:");
        Console.WriteLine("Sell 10 pieces of item 1 and item 2");
        item1.SellItem(10);
        item2.SellItem(10);
        Console.WriteLine();
        Console.WriteLine("Updated items:");
        item1.PrintDetails();
        item2.PrintDetails();
        Console.WriteLine();

        // 3. Restock an item and print the updated details.
        Console.WriteLine("Restock item2:");
        Console.WriteLine("Restock 10 pieces of item 2 ");
        item2.RestockItem(10);
        Console.WriteLine();
        Console.WriteLine("Updated details of items:");
            item1.PrintDetails(); 
        item2.PrintDetails();
        Console.WriteLine();

        // 4. Check if an item is in stock and print a message accordingly.
        Console.WriteLine("Stock Management:");
        Console.WriteLine($"Item1 in stock {item1.IsInStock()}");
        Console.WriteLine($"Item2 in stock {item2.IsInStock()}");
        Console.WriteLine();
    }
}
