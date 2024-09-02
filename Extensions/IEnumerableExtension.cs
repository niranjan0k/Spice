﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Extensions
{
    public static class IEnumerableExtension
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this IEnumerable<T> items, int selectedValue)
        {
            return from item in items
                   select new SelectListItem
                   {
                       Text = item.GetPropertyVelue("Name"),
                       Value = item.GetPropertyVelue("Id"),
                       Selected = item.GetPropertyVelue("Id").Equals(selectedValue.ToString())
                   };
        }
    }
}
