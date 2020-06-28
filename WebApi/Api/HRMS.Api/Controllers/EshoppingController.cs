using System;
using HRMS.IBusiness;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HRMS.DataModel.EshoppingModel;
using HRMS.DataModel;

namespace HRMS.Api.Controllers
{
    [RoutePrefix("api/Eshopping")]
    public class EshoppingController : ApiController
    {
        private readonly IEshoppingBusiness _eshoppingBusiness;

        public EshoppingController(IEshoppingBusiness eshoppingBusiness)
        {
            _eshoppingBusiness = eshoppingBusiness;
        }
        
        [Route("GetAllProduct")]
        [HttpGet]
        public List<EshoppingModel> GetAllProduct()
        {
            return _eshoppingBusiness.GetAllProduct();
        }
    }
}
