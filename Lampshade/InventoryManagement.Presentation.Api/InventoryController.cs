using System.Collections.Generic;
using _01_LampshadeQuery.Contracts.Inventory;
using InventoryManagement.Application.Contracts.Inventory;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Presentation.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryQuery _inventoryQuery;
        private readonly IInventoryApplication _inventoryApplication;

        public InventoryController(IInventoryQuery inventoryQuery, IInventoryApplication inventoryApplication)
        {
            _inventoryQuery = inventoryQuery;
            _inventoryApplication = inventoryApplication;
        }

        [HttpGet("{id:long}")]
        public List<InventoryOperationViewModel> GetOperationsBy(long id)
        {
            return _inventoryApplication.GetOperationLog(id);
        }

        [HttpPost]
        public StockStatus CheckStatus(IsInStock command)
        {
            return _inventoryQuery.CheckStock(command);
        }
    }
}
