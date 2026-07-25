using System;
using System.Collections.Generic;

namespace ShopMaster
{
    // Starter Code: Data Models & Product Catalog
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // "Electronics", "Clothing", "Food", "Books"
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}