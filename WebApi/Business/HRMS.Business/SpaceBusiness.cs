using HRMS.DataModel;
using HRMS.IBusiness;
using HRMS.IRepository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Business
{
    public class SpaceBusiness : ISpaceBusiness
    {
        private readonly ISpaceRepository _spaceRepository;
        public SpaceBusiness(ISpaceRepository spaceRepository)
        {
            _spaceRepository = spaceRepository;
        }
        public List<SpaceModel> GetAllSpaces(int Booking_Id)
        {
            return _spaceRepository.GetAllSpaces(Booking_Id);
        }
        public List<SpaceModel> GetAllParentByBKID(int Booking_Id)
        {
            return _spaceRepository.GetAllParentByBKID(Booking_Id);
        }
        public List<SpaceModel> GetAllParentValues()
        {
            return _spaceRepository.GetAllParentValues();
        }
        
    }
}
