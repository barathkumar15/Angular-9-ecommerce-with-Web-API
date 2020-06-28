using HRMS.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.IRepository
{
    public interface IRepository<T>
    {
        ApiResponse<T> GetById(int id);
        ApiResponse<IEnumerable<T>> GetAll();
        ApiResponse<string> Create(T entity);
        ApiResponse<string> Update(T entity);
        ApiResponse<string> Delete(int id);
    }
}
