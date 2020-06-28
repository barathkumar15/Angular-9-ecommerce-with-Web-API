using HRMS.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Business
{
    public class BaseBusiness
    {
        public void PerformDataAnnotationValidations(object source, ref List<ErrorModel> errorDetails)
        {
            var context = new ValidationContext(source, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            AssociateMetadataType(source);
            var isValid = Validator.TryValidateObject(source, context, results, true);

            ErrorModel errorDetail;

            // Validate all the data annotations rules
            if (!isValid)
            {
                foreach (var validationResult in results)
                {
                    errorDetail = new ErrorModel(validationResult.ErrorMessage);
                    errorDetails.Add(errorDetail);
                }
            }
        }

        private static void AssociateMetadataType(object entity)
        {
            var entityType = entity.GetType();
            foreach (var attribute in entityType.GetCustomAttributes(typeof(MetadataTypeAttribute), true).Cast<MetadataTypeAttribute>())
            {
                TypeDescriptor.AddProviderTransparent(
                new AssociatedMetadataTypeTypeDescriptionProvider(entityType, attribute.MetadataClassType), entityType);
            }
        }
    }
}
