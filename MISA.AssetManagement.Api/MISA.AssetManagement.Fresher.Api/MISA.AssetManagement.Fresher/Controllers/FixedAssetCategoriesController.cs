using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Service;

namespace MISA.AssetManagement.Fresher.Controllers
{
    /// <summary>
    /// Controller quản lý loại tài sản
    /// CreatedBy: TTVinh (14/11/2025)
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class FixedAssetCategoriesController : BaseController<FixedAssetCategory>
    {
        public FixedAssetCategoriesController(IBaseService<FixedAssetCategory> baseService)
            : base(baseService) { }
    }
}
