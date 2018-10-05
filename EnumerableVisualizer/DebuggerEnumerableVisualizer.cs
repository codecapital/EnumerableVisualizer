using CodeCapital.EnumerableVisualizer;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(List<>), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(Array), Description = DebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource), Target = typeof(ArrayList), Description = DebuggerEnumerableVisualizer.Description)]
namespace CodeCapital.EnumerableVisualizer
{
    public class DebuggerEnumerableVisualizer : DialogDebuggerVisualizer
    {
        public const string Description = "Enumerable Visualizer 1.2";

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            Trace.Write(Description);

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

            if (dataStream != null && dataStream.Length > 0)
            {
                var dataTable = JsonHelper.Deserialize(dataStream);

                ShowVisualizerForm(dataTable);
            }
        }

        private static void ShowVisualizerForm(DataTable data)
        {
            var form = new VisualizerForm(data);

            form.ShowDialog();
        }

        public static void TestShowVisualizer(object objectToVisualize)
        {
            //var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerVisualizer));
            var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerEnumerableVisualizer), typeof(EnumerableObjectSource));

            visualizerHost.ShowVisualizer();
        }
    }
}
