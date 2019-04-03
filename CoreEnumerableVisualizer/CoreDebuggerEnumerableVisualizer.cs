using CoreEnumerableVisualizer;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Diagnostics;

//[assembly: DebuggerVisualizer(typeof(CoreDebuggerEnumerableVisualizer),typeof(VisualizerObjectSource),Target = typeof(System.String),Description = "My First Visualizer")]
[assembly: DebuggerVisualizer(typeof(CoreDebuggerEnumerableVisualizer), typeof(VisualizerObjectSource), Target = typeof(System.String), Description = CoreDebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(CoreDebuggerEnumerableVisualizer), typeof(VisualizerObjectSource), TargetTypeName = "System.Collections.Generic.List`1, mscorlib", Description = CoreDebuggerEnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(CoreDebuggerEnumerableVisualizer), typeof(VisualizerObjectSource), TargetTypeName = "System.Collections.Generic.List`1, System.Collections", Description = CoreDebuggerEnumerableVisualizer.Description)]
namespace CoreEnumerableVisualizer
{
    public class CoreDebuggerEnumerableVisualizer
    {
        public const string Description = "XXX Core";

        public CoreDebuggerEnumerableVisualizer()
        {

        }

        public static void TestShowVisualizer(object objectToVisualize)
        {
            //var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerVisualizer));
            //var visualizerHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(CoreDebuggerEnumerableVisualizer));

            //visualizerHost.ShowVisualizer();
        }
    }
}
