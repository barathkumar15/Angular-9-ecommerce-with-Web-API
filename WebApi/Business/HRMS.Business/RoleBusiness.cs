using HRMS.DataModel;
using HRMS.DataModel.Eshopping;
using HRMS.IBusiness;
using HRMS.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMS.Common.Resources;

namespace HRMS.Business
{
    public class RoleBusiness : BaseBusiness, IRoleBusiness
    {
        private readonly IRoleRepository _roleRepository;

        public RoleBusiness(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public ApiResponse<string> CreateRole(RoleModel roleModel)
        {
            ApiResponse<string> response;
            if (roleModel == null)
            {
                response = new ApiResponse<string>(new ErrorModel(CommonMessages.ModelNullError));
                return response;
            }

            List<ErrorModel> errors = new List<ErrorModel>();
            PerformDataAnnotationValidations(roleModel, ref errors);
            //Do Business validation if any.

            if(errors.Any())
            {
                response = new ApiResponse<string>(errors);
                return response;
            }

            response = _roleRepository.Create(roleModel);
            return response;
        }

        public ApiResponse<string> UpdateRole(RoleModel roleModel)
        {
            ApiResponse<string> response;
            if (roleModel == null)
            {
                response = new ApiResponse<string>(new ErrorModel(CommonMessages.ModelNullError));
                return response;
            }

            List<ErrorModel> errors = new List<ErrorModel>();
            PerformDataAnnotationValidations(roleModel, ref errors);
            //Do Business validation if any.

            if (errors.Any())
            {
                response = new ApiResponse<string>(errors);
                return response;
            }

            response = _roleRepository.Update(roleModel);
            return response;
        }

        public ApiResponse<string> DeleteRole(int roleId)
        {
            ApiResponse<string> response;
            if (roleId == 0)
            {
                response = new ApiResponse<string>(new ErrorModel(string.Format(CommonMessages.InvalidID, roleId)));
                return response;
            }

            response = _roleRepository.Delete(roleId);
            return response;
        }

        public ApiResponse<RoleModel> GetRoleById(int roleId)
        {
            ApiResponse<RoleModel> response;
            if (roleId == 0)
            {
                response = new ApiResponse<RoleModel>(new ErrorModel(string.Format(CommonMessages.InvalidID, roleId)));
                return response;
            }

            response = _roleRepository.GetById(roleId);
            return response;
        }

        public ApiResponse<IEnumerable<RoleModel>> GetRoles()
        {
            return _roleRepository.GetAll();
        }
    }
}
