using HRMS.DataModel;
using HRMS.DataModel.Eshopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.IBusiness
{
    public interface IRoleBusiness
    {
        ApiResponse<string> CreateRole(RoleModel roleModel);
        ApiResponse<string> UpdateRole(RoleModel roleModel);
        ApiResponse<string> DeleteRole(int id);
        ApiResponse<RoleModel> GetRoleById(int roleId);
        ApiResponse<IEnumerable<RoleModel>> GetRoles();
    }
}
