using HRMS.DataModel;
using HRMS.DataModel.Eshopping;
using HRMS.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Repository
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public ApiResponse<string> Create(RoleModel entity)
        {
            return new ApiResponse<string>("Role has been created successfully");
        }

        public ApiResponse<string> Update(RoleModel entity)
        {
            return new ApiResponse<string>("Role has been updated successfully");
        }

        public ApiResponse<string> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ApiResponse<IEnumerable<RoleModel>> GetAll()
        {
           return new ApiResponse<IEnumerable<RoleModel>>(Roles());
        }

        public ApiResponse<RoleModel> GetById(int id)
        {
            var role = Roles().FirstOrDefault(x => x.RoleID == id);
            if(role == null)
            {
                return new ApiResponse<RoleModel>(new ErrorModel("Role not found for given id - " + id));
            }

            return new ApiResponse<RoleModel>(role);
        }

        private List<RoleModel> Roles()
        {
            var roles = new List<RoleModel>()
            {
                new RoleModel() { RoleID = 1, RoleName = "Role 1", RoleDescription = "Role description 1", IsActive = true, CreatedBy = "admin" },
                new RoleModel() { RoleID = 2, RoleName = "Role 2", RoleDescription = "Role description 2", IsActive = true, CreatedBy = "admin" },
                new RoleModel() { RoleID = 3, RoleName = "Role 3", RoleDescription = "Role description 3", IsActive = true, CreatedBy = "admin" },
                new RoleModel() { RoleID = 4, RoleName = "Role 4", RoleDescription = "Role description 4", IsActive = true, CreatedBy = "admin" },
                new RoleModel() { RoleID = 5, RoleName = "Role 5", RoleDescription = "Role description 5", IsActive = true, CreatedBy = "admin" }
            };

            return roles;
        }
    }
}
