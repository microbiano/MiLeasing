using MiLeasing.Web.Data;
using MiLeasing.Web.Data.Entities;
using MiLeasing.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiLeasing.Web.Helpers
{
    public class ConverterHelper:IConverterHelper
    {
        private readonly DataContext _dataContext;
        private readonly IComboHelper _comboHelper;

        public ConverterHelper(
            DataContext dataContext,
            IComboHelper comboHelper)
        {
            _dataContext = dataContext;
            _comboHelper = comboHelper;
        }

        public async Task<Contract> ToContractAsync(ContractViewModel model, bool isNew)
        {
            return new Contract
            {
                EndDate = model.EndDate.ToUniversalTime(),
                IsActive = model.IsActive,
                Id = isNew ? 0: model.Id,
                Lessee = await _dataContext.Lessees.FindAsync(model.LesseeId),
                Owner = await _dataContext.Owners.FindAsync(model.OwnerId),
                Price = model.Price,
                Property = await _dataContext.Properties.FindAsync(model.PropertyId),
                Remarks = model.Remarks,
                StartDate = model.StartDate  .ToUniversalTime()           
            };

        }

        public ContractViewModel ToContractViewModel(Contract contract)
        {
            return new ContractViewModel {

                EndDate = contract.EndDateLocal,
                IsActive = contract.IsActive,
                Id = contract.Id,
                Lessee = contract.Lessee,
                Owner = contract.Owner,
                Price = contract.Price,
                Property = contract.Property,
                Remarks = contract.Remarks,
                StartDate = contract.EndDateLocal,
                LesseeId = contract.Lessee.Id,
                Lessees = _comboHelper.GetComboLessees(),
                OwnerId= contract.Owner.Id,
                PropertyId= contract.Property.Id
            };
        }

        public async Task<Property> ToPropertyAsync(PropertyViewModel model, bool isNew)
        {
            return new Property
            {
                Address = model.Address,
                Contracts = isNew ? new List<Contract>() : model.Contracts,
                HasParkingLot = model.HasParkingLot,
                Id = isNew ? 0 : model.Id,
                IsAvailable = model.IsAvailable,
                Neighborhood = model.Neighborhood,
                Owner = await _dataContext.Owners.FindAsync(model.OwnerId),
                PropertyImages = isNew ? new List<PropertyImage>(): model.PropertyImages,
                Price=model.Price,
                PropertyType = await _dataContext.PropertyTypes.FindAsync(model.PropertyTypeId),
                Remarks=model.Remarks,
                Rooms=model.Rooms,
                SquareMeters=model.SquareMeters,
                Stratum=model.Stratum
            };
        }

        public PropertyViewModel ToPropertyViewModel(Property property)
        {
            return new PropertyViewModel
            {
                Address = property.Address,
                Contracts = property.Contracts,
                HasParkingLot = property.HasParkingLot,
                Id = property.Id,
                IsAvailable = property.IsAvailable,
                Neighborhood = property.Neighborhood,
                Owner = property.Owner,
                PropertyImages = property.PropertyImages,
                Price = property.Price,
                PropertyType = property.PropertyType,
                Remarks = property.Remarks,
                Rooms = property.Rooms,
                SquareMeters = property.SquareMeters,
                Stratum = property.Stratum,
                OwnerId = property.Owner.Id,
                PropertyTypeId = property.PropertyType.Id,
                PropertyTypes = _comboHelper.GetComboPropertyTypes()
            };
        }
    }
}
