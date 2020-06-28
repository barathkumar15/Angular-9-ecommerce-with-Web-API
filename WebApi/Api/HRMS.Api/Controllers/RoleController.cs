using HRMS.DataModel;
using HRMS.DataModel.Eshopping;
using HRMS.IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRMS.Api.Controllers
{
    [RoutePrefix("api/Role")]
    public class RoleController : BaseApiController
    {
        private readonly IRoleBusiness _roleBusiness;

        public RoleController(IRoleBusiness roleBusiness)
        {
            _roleBusiness = roleBusiness;
        }

        [Route("CreateRole")]
        [HttpPost]
        public ApiResponse<string> CreateRole([FromBody]RoleModel roleModel)
        {
            return _roleBusiness.CreateRole(roleModel);
        }

        [Route("UpdateRole")]
        [HttpPost]
        public ApiResponse<string> UpdateRole([FromBody]RoleModel roleModel)
        {
            return _roleBusiness.UpdateRole(roleModel);
        }

        [Route("DeleteRole")]
        [HttpPost]
        public ApiResponse<string> DeleteRole([FromBody]RoleModel roleModel)
        {
            return _roleBusiness.DeleteRole(roleModel.RoleID);
        }
        
        [Route("GetRoles")]
        [HttpGet]
        public ApiResponse<IEnumerable<RoleModel>> GetRoles()
        {
            return _roleBusiness.GetRoles();
        }

        [Route("GetRoleById")]
        [HttpGet]
        public ApiResponse<RoleModel> GetRoleById(int roleId)
        {
            return _roleBusiness.GetRoleById(roleId);
        }
    }
}
