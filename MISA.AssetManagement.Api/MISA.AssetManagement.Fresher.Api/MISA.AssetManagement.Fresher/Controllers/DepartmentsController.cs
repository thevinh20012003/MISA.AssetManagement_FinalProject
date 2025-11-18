using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces.Service;

namespace MISA.AssetManagement.Fresher.Controllers
{
    /// <summary>
    /// Controller quản lý bộ phận
    /// CreatedBy: TTVinh (14/11/2025)
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : BaseController<Department>
    {
        public DepartmentsController(IBaseService<Department> baseService)
            : base(baseService) { }
    }
}
