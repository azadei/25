using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
    }

    class Purchase
    {
        public int ItemID { get; set; }
        public int PurchaseQuantity { get; set; }
    }

    static void Main(string[] args)
    {
      
        List<Item> items = new List<Item>
        {
            new Item { ItemID = 1, ItemName = "Biscuit" },
            new Item { ItemID = 2, ItemName = "Chocolate" },
            new Item { ItemID = 3, ItemName = "Butter" },
            new Item { ItemID = 4, ItemName = "Bread" }
        };

        
        List<Purchase> purchases = new List<Purchase>
        {
            new Purchase { ItemID = 1, PurchaseQuantity = 458 },
            new Purchase { ItemID = 2, PurchaseQuantity = 650 },
            new Purchase { ItemID = 3, PurchaseQuantity = 800 },
            new Purchase { ItemID = 3, PurchaseQuantity = 900 },
            new Purchase { ItemID = 3, PurchaseQuantity = 900 },
            new Purchase { ItemID = 4, PurchaseQuantity = 700 },
            new Purchase { ItemID = 4, PurchaseQuantity = 650 }
        };

       
        var innerJoin = from item in items
                        join purchase in purchases on item.ItemID equals purchase.ItemID
                        select new { item.ItemID, item.ItemName, purchase.PurchaseQuantity };

      
        
        foreach (var result in innerJoin)
        {
            Console.WriteLine($"{result.ItemID}\t\t{result.ItemName}\t{result.PurchaseQuantity}");
        }

    }
}