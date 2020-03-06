namespace DeepShallowCopy
{
    using System;

    using Newtonsoft.Json;

    public static class ObjectExtension
    {
        public static T CreateDeepCopy<T>(this T objectToCopy)
        {
            try
            {
                string jsonSerailizedObject = JsonConvert.SerializeObject(objectToCopy);

                return JsonConvert.DeserializeObject<T>(jsonSerailizedObject);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
