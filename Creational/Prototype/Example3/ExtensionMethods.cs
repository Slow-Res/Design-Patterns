using System.IO;
using System.Text.Json;

namespace Design_Patterns.Creational.Prototype.Example3
{
    public static class ExtensionMethods
    {

        public static T DeepCopyBySerialization<T>(this T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            var options = new JsonSerializerOptions
            {
                IncludeFields = true,
            };

            var data = JsonSerializer.Serialize(obj, options);
            return JsonSerializer.Deserialize<T>(data, options);
        }
    }

}

