using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Delegation
{
    public static class AttributeImporter 
    { 
        public static string GetDisplayName(object instance, PropertyInfo propertyInfo)
        {
            string output = "";
            var attr = GetDisplayAttribute(instance, propertyInfo.Name);
            if (attr != null)
            {
                output = attr.Name;
            }
            return output;
        }

        private static DisplayAttribute GetDisplayAttribute(object instance, string name)
        {
            DisplayAttribute output;

            var attributeType = typeof(DisplayAttribute);
            var prop = instance.GetType().GetProperty(name);

            output = (DisplayAttribute)prop.GetCustomAttributes(attributeType, false).FirstOrDefault();

            return output;
        }
    }
}
