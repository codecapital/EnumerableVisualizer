using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.IO;

namespace EnumerableVisualizer
{
    //ToDo Any Console.WriteLine could be sent over in stream as it seems the only way to see any errors from here
    // e.g. outgoingData { data: data, error: error }
    public class EnumerableObjectSource : VisualizerObjectSource
    {
        public override void GetData(object target, Stream outgoingData)
        {
            //MessageBox.Show("B");

            //MessageBox.Show(target.ToString());

            //MessageBox.Show("Bb");

            Console.WriteLine("b");
            Console.WriteLine(target.ToString());
            Console.WriteLine("bb");

            try
            {
                var byteArray = JsonHelper.Serialize(target);
                outgoingData.Write(byteArray, 0, byteArray.Length);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                Console.WriteLine(exp.InnerException);
            }
        }
    }
}
