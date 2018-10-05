using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.IO;
using System.Windows.Forms;

namespace CodeCapital.EnumerableVisualizer
{
    public class EnumerableObjectSource : VisualizerObjectSource
    {
        public override void GetData(object target, Stream outgoingData)
        {
            try
            {
                var byteArray = JsonHelper.Serialize(target);
                outgoingData.Write(byteArray, 0, byteArray.Length);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "VisualizerObjectSource Error");
            }
        }
    }
}
