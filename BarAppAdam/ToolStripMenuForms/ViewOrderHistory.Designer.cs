namespace BarAppAdam
{
    partial class ViewOrderHistory
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrinksInStringFormat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.ShowingFromTillLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.memberDataGridViewTextBoxColumn,
            this.DrinksInStringFormat,
            this.priceTotalDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(843, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // memberDataGridViewTextBoxColumn
            // 
            this.memberDataGridViewTextBoxColumn.DataPropertyName = "Member";
            this.memberDataGridViewTextBoxColumn.HeaderText = "Member";
            this.memberDataGridViewTextBoxColumn.Name = "memberDataGridViewTextBoxColumn";
            this.memberDataGridViewTextBoxColumn.Width = 200;
            // 
            // DrinksInStringFormat
            // 
            this.DrinksInStringFormat.DataPropertyName = "DrinksInStringFormat";
            this.DrinksInStringFormat.HeaderText = "Drinks";
            this.DrinksInStringFormat.Name = "DrinksInStringFormat";
            this.DrinksInStringFormat.Width = 350;
            // 
            // priceTotalDataGridViewTextBoxColumn
            // 
            this.priceTotalDataGridViewTextBoxColumn.DataPropertyName = "PriceTotal";
            this.priceTotalDataGridViewTextBoxColumn.HeaderText = "PriceTotal";
            this.priceTotalDataGridViewTextBoxColumn.Name = "priceTotalDataGridViewTextBoxColumn";
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            // 
            // orderBindingSource3
            // 
            this.orderBindingSource3.DataSource = typeof(BarAppAdam.Entities.Order);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(BarAppAdam.Entities.Order);
            // 
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataSource = typeof(BarAppAdam.Entities.Order);
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(BarAppAdam.Entities.Order);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(12, 12);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 1;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(780, 12);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ShowingFromTillLabel
            // 
            this.ShowingFromTillLabel.AutoSize = true;
            this.ShowingFromTillLabel.Location = new System.Drawing.Point(349, 20);
            this.ShowingFromTillLabel.Name = "ShowingFromTillLabel";
            this.ShowingFromTillLabel.Size = new System.Drawing.Size(53, 15);
            this.ShowingFromTillLabel.TabIndex = 3;
            this.ShowingFromTillLabel.Text = "Showing";
            // 
            // ViewOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.ShowingFromTillLabel);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewOrderHistory";
            this.Text = "ViewOrderHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button Previous;
        private Button Next;
        private Label ShowingFromTillLabel;
        private BindingSource orderBindingSource;
        private BindingSource orderBindingSource1;
        private BindingSource orderBindingSource2;
        private DataGridViewTextBoxColumn drinksInStringFormatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DrinksInStringFormat;
        private DataGridViewTextBoxColumn priceTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource3;
    }
}