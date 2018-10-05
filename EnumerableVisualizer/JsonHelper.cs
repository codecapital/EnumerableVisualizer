using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Windows.Forms;

namespace CodeCapital.EnumerableVisualizer
{
    public static class JsonHelper
    {
        public static byte[] Serialize(object _Object)
        {
            var memoryStream = new MemoryStream();
            var serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Auto
            };

            try
            {
                using (var sw = new StreamWriter(memoryStream))
                using (var writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, _Object);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Serialize Error");
            }

            return memoryStream.ToArray();
        }

        public static DataTable Deserialize(Stream stream)
        {
            var list = new DataTable();

            var serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Auto
            };

            try
            {
                using (var reader = new StreamReader(stream))
                using (var jsonTextReader = new JsonTextReader(reader))
                {
                    var c = reader.ReadToEnd();

                    // check array or object

                    var dataTable = JsonConvert.DeserializeObject<DataTable>(c);

                    return dataTable;
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Deserialize Error");
            }

            return list;
        }

        public static IList<ExpandoObject> Deserialize2(Stream stream)
        {
            var list = new List<ExpandoObject>();

            var serializer = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Auto
            };

            try
            {
                using (var reader = new StreamReader(stream))
                using (var jsonTextReader = new JsonTextReader(reader))
                {
                    var c = reader.ReadToEnd();

                    var b = jsonTextReader.ReadAsString();

                    var a = serializer.Deserialize<IList<ExpandoObject>>(jsonTextReader);

                    var dataTable = JsonConvert.DeserializeObject<DataTable>(reader.ReadToEnd());

                    var test = serializer.Deserialize<DataTable>(jsonTextReader);

                    return a;
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Deserialize Error");
            }

            return list;
        }

        public static string ObjectToString(object _object)
        {
            string _str = string.Empty;
            JsonSerializerSettings _jsonSerializeSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Auto
            };
            _str = JsonConvert.SerializeObject(_object, Newtonsoft.Json.Formatting.Indented, _jsonSerializeSettings);
            return _str;
        }
    }
}
