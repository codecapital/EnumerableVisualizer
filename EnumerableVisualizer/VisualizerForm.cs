using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CodeCapital.EnumerableVisualizer
{
    public partial class VisualizerForm : Form
    {
        private DataTable _dataTable;
        private int _totalCount;

        public VisualizerForm(DataTable dataTable)
        {
            InitializeComponent();

            if (dataTable == null)
            {
                return;
            }

            _dataTable = dataTable;
            _totalCount = _dataTable.Rows.Count;

            UpdateCount();

            VisualizerGridView.DataSource = dataTable;
        }

        private void UpdateCount() => CountLabel.Text = $"Count = {_totalCount}";

        private void UpdateFilteredCount(int count) => CountLabel.Text = $"Count = {count} from {_totalCount}";

        private void ExportToExcelButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Select, copy and paste your selection to Excel.");

            return;

            // This is removed because it is huge

            var myDocumentsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            var saveDialog = new SaveFileDialog
            {
                InitialDirectory = myDocumentsFolderPath,
                RestoreDirectory = true,
                Filter = "Excel files (*.xlsx)|*.xlsx",
                Title = "Export Excel File To"
            };
            //saveDlg.FilterIndex = 0;

            if (saveDialog.ShowDialog() != DialogResult.OK) return;

            var path = saveDialog.FileName;

            //using (var workbook = new XLWorkbook())
            //{
            //    workbook.Worksheets.Add(_dataTable, "DataTable");
            //    workbook.SaveAs(saveDialog.FileName);
            //}
        }

        private void VisualizerGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1) return;

            var searchedText = TextBoxSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchedText)) return;

            var gridCellValue = e.FormattedValue.ToString();

            var startIndexInCellValue = gridCellValue.ToLower().IndexOf(searchedText.ToLower(), StringComparison.Ordinal);

            if (startIndexInCellValue < 0) return;

            e.Handled = true;
            e.PaintBackground(e.CellBounds, true);

            var rectangle = new Rectangle
            {
                Y = e.CellBounds.Y + 2,
                Height = e.CellBounds.Height - 5
            };

            //find the size of the text before the search word in grid cell data.  
            var start = gridCellValue.Substring(0, startIndexInCellValue);

            //size of the search word in the grid cell data  
            var end = gridCellValue.Substring(startIndexInCellValue, searchedText.Length);

            var size1 = TextRenderer.MeasureText(e.Graphics, start, e.CellStyle.Font, e.CellBounds.Size);

            var size2 = TextRenderer.MeasureText(e.Graphics, end, e.CellStyle.Font, e.CellBounds.Size);

            if (size1.Width > 5)
            {
                rectangle.X = e.CellBounds.X + size1.Width - 5;
                rectangle.Width = size2.Width - 6;
            }
            else
            {
                rectangle.X = e.CellBounds.X + 2;
                rectangle.Width = size2.Width - 6;
            }

            using (var brush = new SolidBrush(Color.FromArgb(158, 251, 162, 0)))
            {
                e.Graphics.FillRectangle(brush, rectangle);
            }

            e.PaintContent(e.CellBounds);
        }

        private void toolStripTextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var searchedText = TextBoxSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchedText))
            {
                VisualizerGridView.DataSource = _dataTable;

                ClearSearchButton.Visible = false;
            }
            else
            {
                var afterSearch = SearchDataInDataGridView(searchedText, _dataTable);

                VisualizerGridView.DataSource = afterSearch;

                UpdateFilteredCount(afterSearch.Rows.Count);

                ClearSearchButton.Visible = true;
            }
        }

        private DataTable SearchDataInDataGridView(string searchText, DataTable dataTable)
        {
            var dataView = new DataView(dataTable)
            {
                RowFilter = BuildFilter(searchText, dataTable)
            };

            return dataView.ToTable();
        }

        private static string BuildFilter(string searchText, DataTable dataTable)
        {
            var filterBuilder = new StringBuilder();
            var index = 0;

            foreach (DataColumn column in dataTable.Columns)
            {
                if (index != 0 && index < dataTable.Columns.Count)
                {
                    filterBuilder.Append(" OR ");
                }

                if (column.DataType.Name == "String")
                {
                    filterBuilder.Append($"{column.ColumnName} LIKE '%{searchText}%'");
                }
                else
                {
                    filterBuilder.Append($"CONVERT([{column.ColumnName}], System.String) LIKE '%{searchText}%'");
                }

                index++;
            }

            return filterBuilder.ToString();
        }

        private void ClearSearchButton_Click(object sender, System.EventArgs e) => ClearSearchAndReload();

        private void ClearSearchAndReload()
        {
            TextBoxSearch.Text = "";
            VisualizerGridView.DataSource = _dataTable;
        }

        private void ResetButton_Click(object sender, EventArgs e) => ClearSearchAndReload();
    }
}
