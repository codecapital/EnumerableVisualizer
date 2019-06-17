using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

//using ExpressionTreeVisualizer.Util;

namespace EnumerableVisualizer
{
    public partial class VisualizerWindow : Window {

        public IReadOnlyCollection<object> Data { get; set; } = new List<object>();
        public DataTable DataTable { get; set; } = new DataTable();

        public VisualizerWindow() {
            InitializeComponent();

            // if we could find out which is the current monitor, that would be better
            //var workingAreas = Monitor.AllMonitors.Select(x => x.WorkingArea).ToList();
            //MaxWidth = workingAreas.Min(x => x.Width) * .90;
            //MaxHeight = workingAreas.Min(x => x.Height) * .90;
        }

        public void ShowData(DataTable dataTable)
        {
            JsonTable.ItemsSource = dataTable.DefaultView;

            var rows = JsonTable.ItemsSource.OfType<IDictionary<string, object>>();
            var columns = rows.SelectMany(d => d.Keys).Distinct(StringComparer.OrdinalIgnoreCase);

            foreach (var text in columns)
            {
                var column = new DataGridTextColumn
                {
                    Header = text,
                    Binding = new Binding(text)
                };

                JsonTable.Columns.Add(column);
            }
        }
    }
}
