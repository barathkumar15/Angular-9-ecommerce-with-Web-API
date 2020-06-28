using HRMS.DataModel;
using HRMS.DataModel.EshoppingModel;
using HRMS.IBusiness;
using HRMS.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Business
{
   public class EshoppingBusiness : IEshoppingBusiness
    {
        private readonly IEshoppingRepository _eshoppingRepository;

        public EshoppingBusiness(IEshoppingRepository eshoppingRepository)
        {
            _eshoppingRepository = eshoppingRepository;
        }
        public List<EshoppingModel> GetAllProduct()
        {
            return _eshoppingRepository.GetAllProduct();
        }

    
    }
}
