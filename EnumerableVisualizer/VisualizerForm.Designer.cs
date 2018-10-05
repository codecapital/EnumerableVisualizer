namespace CodeCapital.EnumerableVisualizer
{
    partial class VisualizerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizerForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ResetButton = new System.Windows.Forms.ToolStripButton();
            this.ExportToExcelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TextBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.ClearSearchButton = new System.Windows.Forms.ToolStripButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.VisualizerGridView = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CountLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetButton,
            this.ExportToExcelButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.TextBoxSearch,
            this.ClearSearchButton,
            this.toolStripSeparator2,
            this.CountLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(959, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ResetButton
            // 
            this.ResetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResetButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetButton.Image")));
            this.ResetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(49, 24);
            this.ResetButton.Text = "Reset";
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ExportToExcelButton
            // 
            this.ExportToExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExportToExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportToExcelButton.Image")));
            this.ExportToExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportToExcelButton.Name = "ExportToExcelButton";
            this.ExportToExcelButton.Size = new System.Drawing.Size(112, 24);
            this.ExportToExcelButton.Text = "Export to Excel";
            this.ExportToExcelButton.Click += new System.EventHandler(this.ExportToExcelButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 24);
            this.toolStripLabel1.Text = "Search";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(200, 27);
            this.TextBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxSearch_KeyUp);
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearSearchButton.Image")));
            this.ClearSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(47, 24);
            this.ClearSearchButton.Text = "Clear";
            this.ClearSearchButton.Visible = false;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.VisualizerGridView);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 27);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(959, 533);
            this.panelContent.TabIndex = 1;
            // 
            // VisualizerGridView
            // 
            this.VisualizerGridView.AllowUserToAddRows = false;
            this.VisualizerGridView.AllowUserToDeleteRows = false;
            this.VisualizerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisualizerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisualizerGridView.Location = new System.Drawing.Point(0, 0);
            this.VisualizerGridView.Name = "VisualizerGridView";
            this.VisualizerGridView.ReadOnly = true;
            this.VisualizerGridView.RowTemplate.Height = 24;
            this.VisualizerGridView.Size = new System.Drawing.Size(959, 533);
            this.VisualizerGridView.TabIndex = 0;
            this.VisualizerGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.VisualizerGridView_CellPainting);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // CountLabel
            // 
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(66, 24);
            this.CountLabel.Text = "Count = ";
            // 
            // VisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 560);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VisualizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enumerable Debugger Visualizer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VisualizerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.ToolStripButton ResetButton;
        private System.Windows.Forms.ToolStripButton ExportToExcelButton;
        private System.Windows.Forms.DataGridView VisualizerGridView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TextBoxSearch;
        private System.Windows.Forms.ToolStripButton ClearSearchButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel CountLabel;
    }
}