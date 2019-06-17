//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
using System;
using System.Text.Json.Serialization;

namespace CodeCapital.EnumerableVisualizer
{
    public static class JsonHelper
    {
        public static byte[] Serialize(object objectToSerialize)
        {
            try
            {
                Console.WriteLine(System.Text.Json.Serialization.JsonSerializer.ToString(objectToSerialize));

                return System.Text.Json.Serialization.JsonSerializer.ToUtf8Bytes(objectToSerialize, new JsonSerializerOptions
                {
                    AllowTrailingCommas = true,
                    IgnoreNullValues = true
                });
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine(exp.InnerException);
            }

            return new byte[0];
        }

        //ToDo Use System.Text.Json if possible
        //public static DataTable Deserialize(Stream stream)
        //{
        //    using (var reader = new StreamReader(stream))
        //    {
        //        var jToken = JsonConvert.DeserializeObject(reader.ReadToEnd());

        //        var jArray = new JArray();

        //        if (jToken is JArray parsedArray) ProcessJArray(jArray, parsedArray);

        //        var dataTable = new DataTable();

        //        if (jArray.Count == 0) return dataTable;

        //        try
        //        {
        //            dataTable = JsonConvert.DeserializeObject<DataTable>(jArray.ToString());
        //        }
        //        catch (Exception exp)
        //        {
        //            //MessageBox.Show(exp.Message, "Deserialize Error");
        //        }

        //        return dataTable;
        //    }
        //}

        //ToDo Use System.Text.Json if possible
        //private static void ProcessJArray(JArray jArray, JToken parsedArray)
        //{
        //    // checking for duplicate columns
        //    //var columnList = new Dictionary<string, int>();

        //    foreach (var jsonRow in parsedArray.Children())
        //    {
        //        var row = new JObject();

        //        // One dimensional List
        //        if (!jsonRow.Children().Any())
        //        {
        //            jArray.Add(new JObject { { "List", jsonRow } });

        //            continue;
        //        }

        //        foreach (var column in jsonRow.Children())
        //        {
        //            //Maybe not needed
        //            //if (!column.HasValues) continue;

        //            var jValue = (JProperty)column;

        //            //var columnIndex = CheckColumnName(jValue.Name);

        //            if (column.First is JValue)
        //            {
        //                row.Add(jValue.Name, jValue.Value);
        //            }
        //            else if (column.First is JObject jObject)
        //            {
        //                // This could be made recursive but let's stop it here for now
        //                foreach (var level2Column in jObject.Children())
        //                {
        //                    var jValue2 = (JProperty)level2Column;

        //                    if (level2Column.First is JValue)
        //                    {
        //                        row.Add($"{jValue.Name}.{jValue2.Name}", jValue2.Value);
        //                    }
        //                    else if (level2Column.First is JObject)
        //                    {
        //                        row.Add($"{jValue.Name}.{jValue2.Name}", jValue2.ToString());
        //                    }
        //                }
        //            }
        //        }

        //        jArray.Add(row);
        //    }

        //    //int CheckColumnName(string columnName)
        //    //{
        //    //    if (columnList.TryGetValue(columnName, out var index))
        //    //    {
        //    //        columnList[columnName]++;
        //    //        return index;
        //    //    }

        //    //    //var columnExist = columnList.ContainsKey(columnName);

        //    //    //if (columnExist) return columnList[columnName];

        //    //    columnList.Add(columnName, 1);

        //    //    return 1;
        //    //}
        //}

        //[Obsolete("Will be removed", true)]
        //public static IList<ExpandoObject> Deserialize2(Stream stream)
        //{
        //    var list = new List<ExpandoObject>();

        //    var serializer = new JsonSerializer
        //    {
        //        NullValueHandling = NullValueHandling.Ignore,
        //        TypeNameHandling = TypeNameHandling.Auto
        //    };

        //    try
        //    {
        //        using (var reader = new StreamReader(stream))
        //        using (var jsonTextReader = new JsonTextReader(reader))
        //        {
        //            var c = reader.ReadToEnd();

        //            var b = jsonTextReader.ReadAsString();

        //            var a = serializer.Deserialize<IList<ExpandoObject>>(jsonTextReader);

        //            var dataTable = JsonConvert.DeserializeObject<DataTable>(reader.ReadToEnd());

        //            var test = serializer.Deserialize<DataTable>(jsonTextReader);

        //            return a;
        //        }
        //    }

        //    catch (Exception exp)
        //    {
        //        //MessageBox.Show(exp.Message, "Deserialize Error");
        //    }

        //    return list;
        //}

        //[Obsolete("Will be removed", true)]
        //public static string ObjectToString(object _object)
        //{
        //    string _str = string.Empty;
        //    JsonSerializerSettings _jsonSerializeSettings = new JsonSerializerSettings
        //    {
        //        NullValueHandling = NullValueHandling.Ignore,
        //        TypeNameHandling = TypeNameHandling.Auto
        //    };
        //    _str = JsonConvert.SerializeObject(_object, Newtonsoft.Json.Formatting.Indented, _jsonSerializeSettings);
        //    return _str;
        //}
    }
}
