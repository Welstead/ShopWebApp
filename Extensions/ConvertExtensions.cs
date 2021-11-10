using Microsoft.AspNetCore.Mvc.Rendering;
using ShopWebApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWebApp.Extensions
{
    public static class ConvertExtensions
    {
        public static List<SelectListItem> ConvertToSelectList<T>(this IEnumerable<T> collection, int selectedValue) where T:IPrimaryPoperties
        {
            return (from item in collection
                    select new SelectListItem 
                    { 
                        Text = item.Title,
                        Value = item.Id.ToString(),
                        Selected = (item.Id == selectedValue),
                    }).ToList();
        }
    }
}
