using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.Serialization.JsonSerializer;

namespace EnumerableVisualizer
{
    public static class JsonHelper
    {
        public static byte[] Serialize(object _Object)
        {
            Console.WriteLine("c1");
            //var memoryStream = new MemoryStream();
            //var serializer = new JsonSerializer
            //{
            //    NullValueHandling = NullValueHandling.Ignore,
            //    TypeNameHandling = TypeNameHandling.Auto
            //};

            Console.WriteLine("c2");

            try
            {
                // this is not going to work because we have to use typeOf()
                //var jsonSerializer = new DataContractJsonSerializer(_Object.GetType());
                //using (var ms = new MemoryStream())
                //{
                //    jsonSerializer.WriteObject(ms, _Object.GetType());
                //    ms.Position = 0;
                //    using (var sr = new StreamReader(ms))
                //    {
                //        Console.WriteLine(sr.ReadToEnd());
                //    }
                //}

                Console.WriteLine(JsonSerializer.ToString(_Object));

                //System.Text.Encoding.Unicode.GetBytes(text);
                //return Encoding.ASCII.GetBytes(System.Text.Json.Serialization.JsonSerializer.ToString(_Object));

                return JsonSerializer.ToUtf8Bytes(_Object, new JsonSerializerOptions
                {
                    IgnoreNullValues = true,
                    AllowTrailingCommas = true
                });

                Console.WriteLine("c2-5");

                return new byte[0];

                //using (var sw = new StreamWriter(memoryStream))
                //using (var writer = new JsonTextWriter(sw))
                //{
                //    Console.WriteLine("c3");
                //    serializer.Serialize(writer, _Object);
                //    Console.WriteLine("c4");
                //}



                //StringBuilder sb = new StringBuilder();
                //StringWriter sw2 = new StringWriter(sb);
                //using (var writer = new JsonTextWriter(sw2))
                //{
                //    serializer.Serialize(writer, _Object);
                //}

                //MessageBox.Show(sb.ToString());

                Console.WriteLine("c");
                Debug.WriteLine("C");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine(exp.InnerException);
                //MessageBox.Show(exp.Message, "Serialize Error");
            }

            return new byte[0];

            //return memoryStream.ToArray();
        }

        //ToDo Use System.Text.Json if possible
        public static DataTable Deserialize(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                var jToken = JsonConvert.DeserializeObject(reader.ReadToEnd());

                var jArray = new JArray();

                if (jToken is JArray parsedArray) ProcessJArray(jArray, parsedArray);

                var dataTable = new DataTable();

                if (jArray.Count == 0) return dataTable;

                try
                {
                    dataTable = JsonConvert.DeserializeObject<DataTable>(jArray.ToString());
                }
                catch (Exception exp)
                {
                    //MessageBox.Show(exp.Message, "Deserialize Error");
                }

                return dataTable;
            }
        }

        //ToDo Use System.Text.Json if possible
        private static void ProcessJArray(JArray jArray, JToken parsedArray)
        {
            // checking for duplicate columns
            //var columnList = new Dictionary<string, int>();

            foreach (var jsonRow in parsedArray.Children())
            {
                var row = new JObject();

                // One dimensional List
                if (!jsonRow.Children().Any())
                {
                    jArray.Add(new JObject {{"List", jsonRow}});

                    continue;
                }

                foreach (var column in jsonRow.Children())
                {
                    //Maybe not needed
                    //if (!column.HasValues) continue;

                    var jValue = (JProperty) column;

                    //var columnIndex = CheckColumnName(jValue.Name);

                    if (column.First is JValue)
                    {
                        row.Add(jValue.Name, jValue.Value);
                    }
                    else if (column.First is JObject jObject)
                    {
                        // This could be made recursive but let's stop it here for now
                        foreach (var level2Column in jObject.Children())
                        {
                            var jValue2 = (JProperty) level2Column;

                            if (level2Column.First is JValue)
                            {
                                row.Add($"{jValue.Name}.{jValue2.Name}", jValue2.Value);
                            }
                            else if (level2Column.First is JObject)
                            {
                                row.Add($"{jValue.Name}.{jValue2.Name}", jValue2.ToString());
                            }
                        }
                    }
                }

                jArray.Add(row);
            }

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
        }
    }
}
