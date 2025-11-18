using MISA.Core.Entities;

namespace MISA.Core.Interfaces.Repository
{

    /// <summary>
    /// Interface repository cho bộ phận
    /// CreatedBy: TTVinh (14/11/2025)
    /// </summary>
    public interface IDepartmentRepository : IBaseRepository<Department>
    {
        /// <summary>
        /// Lấy bộ phận theo mã
        /// CreatedBy: TTVinh (14/11/2025)
        /// </summary>
        /// <param name="code">Mã bộ phận</param>
        /// <returns>Entity bộ phận</returns>
        Department GetByCode(string code);
    }
}
