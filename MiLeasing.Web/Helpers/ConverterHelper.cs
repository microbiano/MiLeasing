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

        public ConverterHelper(
            DataContext dataContext)
        {
            _dataContext = dataContext;
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
    }
}
