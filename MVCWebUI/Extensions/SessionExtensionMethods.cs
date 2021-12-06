using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace MVCWebUI.Extensions
{
    public static class SessionExtensionMethods
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            var objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            var objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString)) return null;
            var value = JsonConvert.DeserializeObject<T>(objectString);
            return value;
        }
    }
}