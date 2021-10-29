namespace BarAppAdam
{
    partial class AddMember
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
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.FirstName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.IsOwner = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.Location = new System.Drawing.Point(255, 188);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(75, 23);
            this.AddMemberButton.TabIndex = 0;
            this.AddMemberButton.Text = "Add";
            this.AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(12, 9);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(67, 15);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 23);
            this.textBox2.TabIndex = 4;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(12, 53);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(66, 15);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Last Name:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(318, 23);
            this.textBox3.TabIndex = 6;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(12, 97);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(189, 15);
            this.Address.TabIndex = 5;
            this.Address.Text = "Address ( Streetname Nr Zip City ):";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 159);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(318, 23);
            this.textBox4.TabIndex = 8;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 141);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // IsOwner
            // 
            this.IsOwner.AutoSize = true;
            this.IsOwner.Location = new System.Drawing.Point(12, 188);
            this.IsOwner.Name = "IsOwner";
            this.IsOwner.Size = new System.Drawing.Size(139, 19);
            this.IsOwner.TabIndex = 10;
            this.IsOwner.Text = "Make member owner";
            this.IsOwner.UseVisualStyleBackColor = true;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 222);
            this.Controls.Add(this.IsOwner);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.AddMemberButton);
            this.Name = "AddMember";
            this.Text = "AddMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddMemberButton;
        private Label FirstName;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LastName;
        private TextBox textBox3;
        private Label Address;
        private TextBox textBox4;
        private Label Email;
        private CheckBox IsOwner;
    }
}