using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using InventoryManagement.Application.Contracts.Inventory;
using ShopManagement.Domain.OrderAgg;
using ShopManagement.Domain.Services;

namespace ShopManagement.Infrastructure.InventoryAcl
{
    public class ShopInventoryAcl : IShopInventoryAcl
    {
        private readonly IInventoryApplication _inventoryApplication;

        public ShopInventoryAcl(IInventoryApplication inventoryApplication)
        {
            _inventoryApplication = inventoryApplication;
        }


        public bool ReduceFromInventory(List<OrderItem> items)
        {
            var command = items.Select(orderItem =>
                new ReduceInventory(orderItem.ProductId, orderItem.Count, "خرید مشتری",
                    orderItem.OrderId)).ToList();

            //foreach (var orderItem in items)
            //{
            //    var item = new ReduceInventory(orderItem.ProductId, orderItem.Count,
            //        "خرید مشتری", orderItem.OrderId);
            //    command.Add(item);
            //}

            return _inventoryApplication.Reduce(command).IsSucceed;
        }
    }
}
