﻿namespace InventoryManagement.Application.Contracts.Inventory
{
    public class ReduceInventory
    {
        public long ProductId { get; set; }
        public long Count { get; set; }
        public long OrderId { get; set; }
    }
}