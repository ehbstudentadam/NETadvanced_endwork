namespace BarAppAdam
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AddMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.MemberOrderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Enter MemberID (will be replaced with barcodescanner in future)";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(362, 254);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(347, 23);
            this.LoginButton.TabIndex = 45;
            this.LoginButton.Text = "GO/LOGIN";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMemberToolStripMenuItem,
            this.settingsToolStripMenuItem1,
            this.settingsToolStripMenuItem2,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "Settings";
            // 
            // AddMemberToolStripMenuItem
            // 
            this.AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem";
            this.AddMemberToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.AddMemberToolStripMenuItem.Text = "Add Member";
            this.AddMemberToolStripMenuItem.Click += new System.EventHandler(this.AddMemberToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderHistoryToolStripMenuItem,
            this.MembersToolStripMenuItem,
            this.MemberOrderHistoryToolStripMenuItem});
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.settingsToolStripMenuItem1.Text = "View";
            // 
            // OrderHistoryToolStripMenuItem
            // 
            this.OrderHistoryToolStripMenuItem.Name = "OrderHistoryToolStripMenuItem";
            this.OrderHistoryToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.OrderHistoryToolStripMenuItem.Text = "Order History";
            this.OrderHistoryToolStripMenuItem.Click += new System.EventHandler(this.OrderHistoryToolStripMenuItem_Click);
            // 
            // MembersToolStripMenuItem
            // 
            this.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem";
            this.MembersToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.MembersToolStripMenuItem.Text = "All Members";
            this.MembersToolStripMenuItem.Click += new System.EventHandler(this.MembersToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem2
            // 
            this.settingsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditMembersToolStripMenuItem,
            this.EditDrinksToolStripMenuItem});
            this.settingsToolStripMenuItem2.Name = "settingsToolStripMenuItem2";
            this.settingsToolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.settingsToolStripMenuItem2.Text = "Edit";
            // 
            // EditMembersToolStripMenuItem
            // 
            this.EditMembersToolStripMenuItem.Name = "EditMembersToolStripMenuItem";
            this.EditMembersToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.EditMembersToolStripMenuItem.Text = "Edit Members";
            this.EditMembersToolStripMenuItem.Click += new System.EventHandler(this.EditMembersToolStripMenuItem_Click);
            // 
            // EditDrinksToolStripMenuItem
            // 
            this.EditDrinksToolStripMenuItem.Name = "EditDrinksToolStripMenuItem";
            this.EditDrinksToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.EditDrinksToolStripMenuItem.Text = "Edit Drinks";
            this.EditDrinksToolStripMenuItem.Click += new System.EventHandler(this.EditDrinksToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(362, 225);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(347, 23);
            this.IdTextbox.TabIndex = 49;
            this.IdTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IdTextbox_KeyDown);
            // 
            // MemberOrderHistoryToolStripMenuItem
            // 
            this.MemberOrderHistoryToolStripMenuItem.Name = "MemberOrderHistoryToolStripMenuItem";
            this.MemberOrderHistoryToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.MemberOrderHistoryToolStripMenuItem.Text = "Member Order History";
            this.MemberOrderHistoryToolStripMenuItem.Click += new System.EventHandler(this.MemberOrderHistoryToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 467);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Self Register Bar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button LoginButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem AddMemberToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem1;
        private ToolStripMenuItem OrderHistoryToolStripMenuItem;
        private ToolStripMenuItem MembersToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem2;
        private ToolStripMenuItem EditMembersToolStripMenuItem;
        private ToolStripMenuItem EditDrinksToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private TextBox IdTextbox;
        private ToolStripMenuItem MemberOrderHistoryToolStripMenuItem;
    }
}