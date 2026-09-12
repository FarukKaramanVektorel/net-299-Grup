using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _12_09_2026
{
    internal class EnumExtentions
    {
        public static string GetDescription(Enum value)
        {
            FieldInfo fi=value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute= fi.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description??value.ToString();
        }
    }
}
