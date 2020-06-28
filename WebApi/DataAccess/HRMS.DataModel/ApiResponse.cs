using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DataModel
{
    public class ApiResponse<T>
    {
        public ApiResponse(IList<ErrorModel> errors)
        {
            this.Errors = errors;
        }

        public ApiResponse(ErrorModel error)
        {
            this.Errors = new List<ErrorModel>() { error };
        }

        public ApiResponse(T result)
        {
            this.Result = result;
        }

        public T Result { get; private set; }

        public IList<ErrorModel> Errors { get; private set; }

        public bool HasErrors
        {
            get
            {
                return this.Errors != null && this.Errors.Count > 0;
            }
        }

        public void AddError(ErrorModel error)
        {
            if (this.Errors == null)
            {
                this.Errors = new List<ErrorModel>() { error };
            }
            else
            {
                this.Errors.Add(error);
            }
        }

        public void AddErrors(IList<ErrorModel> errors)
        {
            this.Errors = errors;
        }

        public string ToErrorString()
        {
            if (this.HasErrors)
            {
                return string.Join(", ", this.Errors.Select(p => p.Message));
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
