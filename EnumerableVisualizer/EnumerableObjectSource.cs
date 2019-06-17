using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.IO;

namespace CodeCapital.EnumerableVisualizer
{
    public class EnumerableObjectSource : VisualizerObjectSource
    {
        //ToDo Any Console.WriteLine could be sent over in stream as it seems the only way to see any errors from here
        // e.g. outgoingData { data: data, error: error }
        public override void GetData(object target, Stream outgoingData)
        {
            Console.WriteLine(target.ToString());

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
