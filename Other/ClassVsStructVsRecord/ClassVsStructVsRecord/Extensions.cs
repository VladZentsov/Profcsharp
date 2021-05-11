using System.Text.Json;

namespace RecordPrototype
{
    public static class Extensions
    {
        public static string SerializeObject<T>(this T obj) => JsonSerializer.Serialize<T>(obj);
        static public T DeserializeObject<T>(this string obj) => JsonSerializer.Deserialize<T>(obj);

    }
}
