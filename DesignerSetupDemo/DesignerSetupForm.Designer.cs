namespace DesignerSetupDemo
{
    partial class DesignerSetupForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.orderTotalDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.shipCityDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.shipRegionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.shipCountryRegionDataGridViewTextBoxColumn = new DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn();
            this.customerOrderDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newDataSet = new DesignerSetupDemo.NewDataSet();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.filterStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.showAllLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderTotalDataGridViewTextBoxColumn,
            this.shipCityDataGridViewTextBoxColumn,
            this.shipRegionDataGridViewTextBoxColumn,
            this.shipCountryRegionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerOrderDataBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(896, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTotalDataGridViewTextBoxColumn
            // 
            this.orderTotalDataGridViewTextBoxColumn.DataPropertyName = "OrderTotal";
            this.orderTotalDataGridViewTextBoxColumn.HeaderText = "OrderTotal";
            this.orderTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTotalDataGridViewTextBoxColumn.Name = "orderTotalDataGridViewTextBoxColumn";
            this.orderTotalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipCityDataGridViewTextBoxColumn
            // 
            this.shipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity";
            this.shipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity";
            this.shipCityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipCityDataGridViewTextBoxColumn.Name = "shipCityDataGridViewTextBoxColumn";
            this.shipCityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shipCityDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipRegionDataGridViewTextBoxColumn
            // 
            this.shipRegionDataGridViewTextBoxColumn.DataPropertyName = "ShipRegion";
            this.shipRegionDataGridViewTextBoxColumn.HeaderText = "ShipRegion";
            this.shipRegionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipRegionDataGridViewTextBoxColumn.Name = "shipRegionDataGridViewTextBoxColumn";
            this.shipRegionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shipRegionDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipCountryRegionDataGridViewTextBoxColumn
            // 
            this.shipCountryRegionDataGridViewTextBoxColumn.DataPropertyName = "ShipCountryRegion";
            this.shipCountryRegionDataGridViewTextBoxColumn.HeaderText = "ShipCountryRegion";
            this.shipCountryRegionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipCountryRegionDataGridViewTextBoxColumn.Name = "shipCountryRegionDataGridViewTextBoxColumn";
            this.shipCountryRegionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shipCountryRegionDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerOrderDataBindingSource
            // 
            this.customerOrderDataBindingSource.DataMember = "CustomerOrderData";
            this.customerOrderDataBindingSource.DataSource = this.newDataSet;
            // 
            // newDataSet
            // 
            this.newDataSet.DataSetName = "NewDataSet";
            this.newDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterStatusLabel,
            this.showAllLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 293);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(896, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // filterStatusLabel
            // 
            this.filterStatusLabel.Name = "filterStatusLabel";
            this.filterStatusLabel.Size = new System.Drawing.Size(0, 20);
            this.filterStatusLabel.Visible = false;
            // 
            // showAllLabel
            // 
            this.showAllLabel.IsLink = true;
            this.showAllLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.showAllLabel.Name = "showAllLabel";
            this.showAllLabel.Size = new System.Drawing.Size(67, 20);
            this.showAllLabel.Text = "Show &All";
            this.showAllLabel.Visible = false;
            this.showAllLabel.Click += new System.EventHandler(this.showAllLabel_Click);
            // 
            // DesignerSetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 315);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DesignerSetupForm";
            this.Text = "DataGridView AutoFilter Demo (C# Designer Setup)";
            this.Load += new System.EventHandler(this.DesignerSetupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerOrderDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataSet)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn orderTotalDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn shipCityDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn shipRegionDataGridViewTextBoxColumn;
        private DataGridViewAutoFilter.DataGridViewAutoFilterTextBoxColumn shipCountryRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerOrderDataBindingSource;
        private NewDataSet newDataSet;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel filterStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel showAllLabel;
    }
}

