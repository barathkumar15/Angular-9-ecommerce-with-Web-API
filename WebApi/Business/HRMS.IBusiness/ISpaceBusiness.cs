using HRMS.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.IBusiness
{
    public interface ISpaceBusiness
    {
        List<SpaceModel> GetAllSpaces(int Booking_Id);
        List<SpaceModel> GetAllParentByBKID(int Booking_Id);
        List<SpaceModel> GetAllParentValues();
    }
}
