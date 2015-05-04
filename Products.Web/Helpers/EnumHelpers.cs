using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Products.Web.Helpers
{
    public static class EnumHelpers
    {
        public static IEnumerable<SelectListItem> GetItems(this Type enumType, int? selectedValue)
        {
            if (!typeof(Enum).IsAssignableFrom(enumType))
            {
                throw new ArgumentException("Type must be enum");
            }

            var names  = Enum.GetNames (enumType);
            var values = Enum.GetValues(enumType).Cast<int>();
            var items  = names.Zip( values,  (_name, _value) => 
                new SelectListItem { 
                    Text = GetName(enumType, _name),
                    Value = _value.ToString(),
                    Selected = _value == selectedValue
                });

            return items;
        }

        public static string GetName(this Type enumType, string name)
        {

            var result = name;

            var attribute = enumType
                .GetField(name)
                .GetCustomAttributes(inherit: false)
                .OfType<DisplayAttribute>()
                .FirstOrDefault();

            if (attribute != null)
            {
                result = attribute.GetName();
            }

            return result;
        }

    }
}