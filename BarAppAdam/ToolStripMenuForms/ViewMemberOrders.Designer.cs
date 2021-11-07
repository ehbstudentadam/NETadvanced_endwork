namespace BarAppAdam.ToolStripMenuForms
{
    partial class ViewMemberOrders
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
            this.drinksInStringFormatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MemberIDLabel = new System.Windows.Forms.Label();
            this.SearchMemberButton = new System.Windows.Forms.Button();
            this.MemberIDTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WalletTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.ShowingFromTillLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.memberDataGridViewTextBoxColumn,
            this.drinksInStringFormatDataGridViewTextBoxColumn,
            this.priceTotalDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(844, 277);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Order";
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
            // drinksInStringFormatDataGridViewTextBoxColumn
            // 
            this.drinksInStringFormatDataGridViewTextBoxColumn.DataPropertyName = "DrinksInStringFormat";
            this.drinksInStringFormatDataGridViewTextBoxColumn.HeaderText = "Drinks";
            this.drinksInStringFormatDataGridViewTextBoxColumn.Name = "drinksInStringFormatDataGridViewTextBoxColumn";
            this.drinksInStringFormatDataGridViewTextBoxColumn.Width = 350;
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
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(BarAppAdam.Entities.Order);
            // 
            // MemberIDLabel
            // 
            this.MemberIDLabel.AutoSize = true;
            this.MemberIDLabel.Location = new System.Drawing.Point(12, 15);
            this.MemberIDLabel.Name = "MemberIDLabel";
            this.MemberIDLabel.Size = new System.Drawing.Size(69, 15);
            this.MemberIDLabel.TabIndex = 1;
            this.MemberIDLabel.Text = "Member ID:";
            // 
            // SearchMemberButton
            // 
            this.SearchMemberButton.Location = new System.Drawing.Point(307, 12);
            this.SearchMemberButton.Name = "SearchMemberButton";
            this.SearchMemberButton.Size = new System.Drawing.Size(75, 23);
            this.SearchMemberButton.TabIndex = 2;
            this.SearchMemberButton.Text = "Search";
            this.SearchMemberButton.UseVisualStyleBackColor = true;
            this.SearchMemberButton.Click += new System.EventHandler(this.SearchMemberButton_Click);
            // 
            // MemberIDTextbox
            // 
            this.MemberIDTextbox.Location = new System.Drawing.Point(87, 12);
            this.MemberIDTextbox.Name = "MemberIDTextbox";
            this.MemberIDTextbox.Size = new System.Drawing.Size(214, 23);
            this.MemberIDTextbox.TabIndex = 3;
            this.MemberIDTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MemberIDTextbox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wallet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            // 
            // WalletTextbox
            // 
            this.WalletTextbox.Location = new System.Drawing.Point(87, 117);
            this.WalletTextbox.Name = "WalletTextbox";
            this.WalletTextbox.Size = new System.Drawing.Size(214, 23);
            this.WalletTextbox.TabIndex = 7;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(87, 88);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(214, 23);
            this.LastNameTextbox.TabIndex = 8;
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(87, 59);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(214, 23);
            this.FirstNameTextbox.TabIndex = 9;
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(12, 170);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(105, 23);
            this.Previous.TabIndex = 11;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(751, 170);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(105, 23);
            this.Next.TabIndex = 12;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ShowingFromTillLabel
            // 
            this.ShowingFromTillLabel.AutoSize = true;
            this.ShowingFromTillLabel.Location = new System.Drawing.Point(360, 174);
            this.ShowingFromTillLabel.Name = "ShowingFromTillLabel";
            this.ShowingFromTillLabel.Size = new System.Drawing.Size(130, 15);
            this.ShowingFromTillLabel.TabIndex = 13;
            this.ShowingFromTillLabel.Text = "Showing records: 0 - 10";
            // 
            // ViewMemberOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 488);
            this.Controls.Add(this.ShowingFromTillLabel);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.WalletTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MemberIDTextbox);
            this.Controls.Add(this.SearchMemberButton);
            this.Controls.Add(this.MemberIDLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewMemberOrders";
            this.Text = "ViewMemberOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label MemberIDLabel;
        private Button SearchMemberButton;
        private TextBox MemberIDTextbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox WalletTextbox;
        private TextBox LastNameTextbox;
        private TextBox FirstNameTextbox;
        private Button Previous;
        private Button Next;
        private Label ShowingFromTillLabel;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn memberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn drinksInStringFormatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
    }
}