using Microsoft.AspNetCore.Mvc.Rendering;
using MiLeasing.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace MiLeasing.Web.Helpers
{
    public class ComboHelper : IComboHelper
    {
        private readonly DataContext _dataContext;

        public ComboHelper(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public IEnumerable<SelectListItem> GetComboPropertyTypes()
        {
            var list = _dataContext.PropertyTypes.Select(pt => new SelectListItem
            {
                Text = pt.Name,
                Value = $"{pt.Id}"
            })
                .OrderBy(pt => pt.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "Select Property Type...",
                Value = "0"
            });

            return list;
        }

    }
}
