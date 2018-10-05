using System.Data;
using System.Windows.Forms;

namespace CodeCapital.EnumerableVisualizer
{
    public partial class VisualizerForm : Form
    {
        public VisualizerForm(DataTable dataTable)
        {
            InitializeComponent();

            if (dataTable == null)
            {
                return;
            }

            VisualizerGridView.DataSource = dataTable;
        }

        private void ExportToExcelButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Exporting to excel");
        }
    }
}
