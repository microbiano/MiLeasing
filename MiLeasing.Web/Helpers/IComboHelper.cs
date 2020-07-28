using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MiLeasing.Web.Helpers
{
    public interface IComboHelper
    {
        IEnumerable<SelectListItem> GetComboPropertyTypes();
        IEnumerable<SelectListItem> GetComboLessees();
    }
}