using HRMS.DataModel;
using HRMS.IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HRMS.Api.Controllers
{
    [RoutePrefix("api/Space")]
    public class SpaceController : BaseApiController
    {
      

        private readonly ISpaceBusiness _spaceBusiness;
        public SpaceController(ISpaceBusiness spaceBusiness)
        {
            _spaceBusiness = spaceBusiness;
        }

        [Route("GetAllSpaces")]
        [HttpGet]
        public List<SpaceModel> GetAllSpaces(int Booking_Id)
        {
            return _spaceBusiness.GetAllSpaces(Booking_Id);
        }
        [Route("GetAllParentByBKID")]
        [HttpGet]
        public List<SpaceModel> GetAllParentByBKID(int Booking_Id)
        {
            return _spaceBusiness.GetAllParentByBKID(Booking_Id);
        }

        [Route("GetAllParentValues")]
        [HttpGet]
        public List<SpaceModel> GetAllParentValues()
        {
            return _spaceBusiness.GetAllParentValues();
        }
    }
}
