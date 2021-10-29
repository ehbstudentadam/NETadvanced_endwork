namespace BarAppAdam.ToolStripMenuForms
{
    partial class EditMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserIdButtonSearch = new System.Windows.Forms.Button();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter MemberID to edit:";
            // 
            // UserIdButtonSearch
            // 
            this.UserIdButtonSearch.Location = new System.Drawing.Point(228, 140);
            this.UserIdButtonSearch.Name = "UserIdButtonSearch";
            this.UserIdButtonSearch.Size = new System.Drawing.Size(285, 23);
            this.UserIdButtonSearch.TabIndex = 1;
            this.UserIdButtonSearch.Text = "Search";
            this.UserIdButtonSearch.UseVisualStyleBackColor = true;
            this.UserIdButtonSearch.Click += new System.EventHandler(this.UserIdButtonSearch_Click);
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(228, 111);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(285, 23);
            this.UserIdTextBox.TabIndex = 2;
            // 
            // EditMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.UserIdButtonSearch);
            this.Controls.Add(this.label1);
            this.Name = "EditMember";
            this.Text = "EditMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button UserIdButtonSearch;
        private TextBox UserIdTextBox;
    }
}