
namespace PresentationLayer
{
    partial class BarOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarOrderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BarDatePick = new System.Windows.Forms.DateTimePicker();
            this.PriceTBox = new System.Windows.Forms.TextBox();
            this.Create_Btn = new System.Windows.Forms.Button();
            this.Read_Btn = new System.Windows.Forms.Button();
            this.Update_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BarGridView = new System.Windows.Forms.DataGridView();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.resortDbNewDataSet = new PresentationLayer.ResortDbNewDataSet();
            this.barOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barOrdersTableAdapter = new PresentationLayer.ResortDbNewDataSetTableAdapters.BarOrdersTableAdapter();
            this.barOrderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resortDbNewDataSet1 = new PresentationLayer.ResortDbNewDataSet1();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new PresentationLayer.ResortDbNewDataSet1TableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortDbNewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortDbNewDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "OrderDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TotalPrice";
            // 
            // BarDatePick
            // 
            this.BarDatePick.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarDatePick.Location = new System.Drawing.Point(74, 81);
            this.BarDatePick.Name = "BarDatePick";
            this.BarDatePick.Size = new System.Drawing.Size(327, 29);
            this.BarDatePick.TabIndex = 3;
            // 
            // PriceTBox
            // 
            this.PriceTBox.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTBox.Location = new System.Drawing.Point(74, 169);
            this.PriceTBox.Name = "PriceTBox";
            this.PriceTBox.Size = new System.Drawing.Size(327, 29);
            this.PriceTBox.TabIndex = 4;
            // 
            // Create_Btn
            // 
            this.Create_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_Btn.Location = new System.Drawing.Point(484, 251);
            this.Create_Btn.Name = "Create_Btn";
            this.Create_Btn.Size = new System.Drawing.Size(110, 51);
            this.Create_Btn.TabIndex = 5;
            this.Create_Btn.Text = "Create";
            this.Create_Btn.UseVisualStyleBackColor = true;
            this.Create_Btn.Click += new System.EventHandler(this.Create_Btn_Click);
            // 
            // Read_Btn
            // 
            this.Read_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read_Btn.Location = new System.Drawing.Point(599, 251);
            this.Read_Btn.Name = "Read_Btn";
            this.Read_Btn.Size = new System.Drawing.Size(110, 51);
            this.Read_Btn.TabIndex = 6;
            this.Read_Btn.Text = "Find";
            this.Read_Btn.UseVisualStyleBackColor = true;
            this.Read_Btn.Click += new System.EventHandler(this.Read_Btn_Click);
            // 
            // Update_Btn
            // 
            this.Update_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Btn.Location = new System.Drawing.Point(715, 251);
            this.Update_Btn.Name = "Update_Btn";
            this.Update_Btn.Size = new System.Drawing.Size(110, 51);
            this.Update_Btn.TabIndex = 7;
            this.Update_Btn.Text = "Update";
            this.Update_Btn.UseVisualStyleBackColor = true;
            this.Update_Btn.Click += new System.EventHandler(this.Update_Btn_Click);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.Location = new System.Drawing.Point(831, 251);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(110, 51);
            this.Delete_Btn.TabIndex = 8;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Customer(s)";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientsBindingSource;
            this.comboBox1.DisplayMember = "PhoneNumber";
            this.comboBox1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(327, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(BussinessLayer.Client);
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataSource = typeof(BussinessLayer.Client);
            // 
            // BarGridView
            // 
            this.BarGridView.AutoGenerateColumns = false;
            this.BarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BarGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barOrderIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.BarGridView.DataSource = this.barOrdersBindingSource;
            this.BarGridView.Location = new System.Drawing.Point(484, 42);
            this.BarGridView.Name = "BarGridView";
            this.BarGridView.Size = new System.Drawing.Size(457, 178);
            this.BarGridView.TabIndex = 11;
            this.BarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BarGridView_CellContentClick);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.Color.Black;
            this.ResultLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(595, 316);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(110, 65);
            this.ResultLabel.TabIndex = 12;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resortDbNewDataSet
            // 
            this.resortDbNewDataSet.DataSetName = "ResortDbNewDataSet";
            this.resortDbNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barOrdersBindingSource
            // 
            this.barOrdersBindingSource.DataMember = "BarOrders";
            this.barOrdersBindingSource.DataSource = this.resortDbNewDataSet;
            // 
            // barOrdersTableAdapter
            // 
            this.barOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // barOrderIdDataGridViewTextBoxColumn
            // 
            this.barOrderIdDataGridViewTextBoxColumn.DataPropertyName = "BarOrderId";
            this.barOrderIdDataGridViewTextBoxColumn.HeaderText = "BarOrderId";
            this.barOrderIdDataGridViewTextBoxColumn.Name = "barOrderIdDataGridViewTextBoxColumn";
            this.barOrderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // resortDbNewDataSet1
            // 
            this.resortDbNewDataSet1.DataSetName = "ResortDbNewDataSet1";
            this.resortDbNewDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.resortDbNewDataSet1;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // BarOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PresentationLayer.Properties.Resources.photo_1572116469696_31de0f17cc34;
            this.ClientSize = new System.Drawing.Size(984, 390);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BarGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Update_Btn);
            this.Controls.Add(this.Read_Btn);
            this.Controls.Add(this.Create_Btn);
            this.Controls.Add(this.PriceTBox);
            this.Controls.Add(this.BarDatePick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BarOrderForm";
            this.Text = "Resort Manager 2000 - Bar";
            this.Load += new System.EventHandler(this.BarOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortDbNewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortDbNewDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BarDatePick;
        private System.Windows.Forms.TextBox PriceTBox;
        private System.Windows.Forms.Button Create_Btn;
        private System.Windows.Forms.Button Read_Btn;
        private System.Windows.Forms.Button Update_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.DataGridView BarGridView;
        private System.Windows.Forms.Label ResultLabel;
        private ResortDbNewDataSet resortDbNewDataSet;
        private System.Windows.Forms.BindingSource barOrdersBindingSource;
        private ResortDbNewDataSetTableAdapters.BarOrdersTableAdapter barOrdersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barOrderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private ResortDbNewDataSet1 resortDbNewDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private ResortDbNewDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter;
    }
}