using HRMS.DataModel;
using HRMS.DataModel.EshoppingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.IBusiness
{
    public interface IEshoppingBusiness
    {
        List<EshoppingModel> GetAllProduct();
      
    }
}
