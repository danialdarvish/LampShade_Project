using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Product", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListProducts, "ListProducts"),
                        new PermissionDto(ShopPermissions.SearchProducts, "SearchProducts"),
                        new PermissionDto(ShopPermissions.CreateProducts, "CreateProduct"),
                        new PermissionDto(ShopPermissions.EditProducts, "EditProduct"),
                    }
                },
                {
                    "ProductCategory", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ListProductCategories, "ListProductCategories"),
                        new PermissionDto(ShopPermissions.SearchProductCategories, "SearchProductCategories"),
                        new PermissionDto(ShopPermissions.CreateProductCategories, "CreateProductCategory"),
                        new PermissionDto(ShopPermissions.EditProductCategories, "EditProductCategory"),
                    }
                },

            };
        }
    }
}
