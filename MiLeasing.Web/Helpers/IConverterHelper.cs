using MiLeasing.Web.Data.Entities;
using MiLeasing.Web.Models;
using System.Threading.Tasks;

namespace MiLeasing.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew);
        
        PropertyViewModel ToPropertyViewModel(Property property);
        Task <Contract>ToContractAsync(ContractViewModel model,bool isNew);
    }
}