using CodeCapital.EnumerableVisualizer;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Windows.Forms;

[assembly: DebuggerVisualizer(typeof(DebuggerVisualizer), typeof(EnumerableObjectSource), Target = typeof(List<>), Description = DebuggerVisualizer.Name)]
namespace CodeCapital.EnumerableVisualizer
{

    public class DebuggerVisualizer : DialogDebuggerVisualizer
    {
        public const string Name = "Enumerable Visualizer 1.0";

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            Trace.Write(Name);

            try
            {
                ShowVisualizer(objectProvider);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception getting object data: " + ex.Message);
            }

        }

        private static void ShowVisualizer(IVisualizerObjectProvider objectProvider)
        {
            Trace.WriteLine("Hello Update 3");

            var dataStream = objectProvider.GetData();

            IList<ExpandoObject> myData = new List<ExpandoObject>();

            var dataTable = new DataTable();

            if (dataStream != null && dataStream.Length > 0)
            {
                //myData = JsonHelper.Deserialize(dataStream);

                dataTable = JsonHelper.Deserialize(dataStream);

                ShowVisualizerForm(dataTable, "Helloo");

                //ListDebuggerVisualizerClient.ShowVisualizerForm((IList)myData, "Helloo");
            }

            if (myData == null)
            {
                return;
            }

            //var converter = new ExpandoObjectConverter();


            //dynamic message = JsonConvert.DeserializeObject<ExpandoObject>(jsonString, converter);

            //var data = (IList)objectProvider.GetObject();
            //var data = (IList)myData;
            //var itemType = data.GetType().GetProperty("Item").PropertyType;
            //if (itemType == typeof(string))
            //{
            //    var prim = new List<PrimitiveListItem>();
            //    foreach (string strItem in data.Cast<string>())
            //    {
            //        var pli = new PrimitiveListItem
            //        {
            //            Value = strItem
            //        };
            //        prim.Add(pli);
            //    }
            //    ListDebuggerVisualizerClient.ShowVisualizerForm(prim, itemType.Name);
            //}
            //else if (itemType.IsPrimitive)
            //{
            //    var prim = new List<PrimitiveListItem>();
            //    foreach (object objItem in data.Cast<object>())
            //    {
            //        var pli = new PrimitiveListItem
            //        {
            //            Value = objItem.ToString()
            //        };
            //        prim.Add(pli);
            //    }
            //    ListDebuggerVisualizerClient.ShowVisualizerForm(prim, itemType.Name);
            //}
            //else
            //{
            //    ListDebuggerVisualizerClient.ShowVisualizerForm(data, itemType.Name);
            //}
        }

        public static void ShowVisualizerForm(DataTable data, string typeName)
        {
            var form = new VisualizerForm(data);

            form.ShowDialog();
        }

        public static void TestShowVisualizer(object objectToVisualize)
        {
            //var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerVisualizer));
            var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerVisualizer), typeof(EnumerableObjectSource));

            visualizerHost.ShowVisualizer();
        }
    }
}
