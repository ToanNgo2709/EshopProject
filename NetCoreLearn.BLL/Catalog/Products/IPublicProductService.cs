using NetCoreLearn.ViewModel.Catalog.Products;
using NetCoreLearn.ViewModel.Catalog.Products.Dtos.Public;
using NetCoreLearn.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreLearn.BLL.Catalog.Products
{
    public interface IPublicProductService
    {
        public Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest  request);

        Task<List<ProductViewModel>> GetAll();
    }
}
