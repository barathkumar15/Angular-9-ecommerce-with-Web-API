using HRMS.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.IRepository
{
    public interface ISpaceRepository
    {
        List<SpaceModel> GetAllSpaces(int Booking_Id);
        List<SpaceModel> GetAllParentByBKID(int Booking_Id);
        List<SpaceModel> GetAllParentValues();
       
    }
}
