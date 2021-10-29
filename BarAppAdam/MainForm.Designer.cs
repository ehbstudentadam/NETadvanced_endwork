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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDrinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(206, 179);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 29);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Enter MemberID (will be replaced with barcodescanner in future)";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(206, 214);
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
            this.settingsToolStripMenuItem,
            this.settingsToolStripMenuItem1,
            this.settingsToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "Settings";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.settingsToolStripMenuItem.Text = "Add Member";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderHistoryToolStripMenuItem,
            this.membersToolStripMenuItem});
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.settingsToolStripMenuItem1.Text = "View";
            // 
            // orderHistoryToolStripMenuItem
            // 
            this.orderHistoryToolStripMenuItem.Name = "orderHistoryToolStripMenuItem";
            this.orderHistoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orderHistoryToolStripMenuItem.Text = "Order History";
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // settingsToolStripMenuItem2
            // 
            this.settingsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMembersToolStripMenuItem,
            this.editDrinksToolStripMenuItem});
            this.settingsToolStripMenuItem2.Name = "settingsToolStripMenuItem2";
            this.settingsToolStripMenuItem2.Size = new System.Drawing.Size(39, 20);
            this.settingsToolStripMenuItem2.Text = "Edit";
            // 
            // editMembersToolStripMenuItem
            // 
            this.editMembersToolStripMenuItem.Name = "editMembersToolStripMenuItem";
            this.editMembersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editMembersToolStripMenuItem.Text = "Edit Members";
            // 
            // editDrinksToolStripMenuItem
            // 
            this.editDrinksToolStripMenuItem.Name = "editDrinksToolStripMenuItem";
            this.editDrinksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editDrinksToolStripMenuItem.Text = "Edit Drinks";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 467);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private RichTextBox richTextBox1;
        private Label label2;
        private Button LoginButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem1;
        private ToolStripMenuItem orderHistoryToolStripMenuItem;
        private ToolStripMenuItem membersToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem2;
        private ToolStripMenuItem editMembersToolStripMenuItem;
        private ToolStripMenuItem editDrinksToolStripMenuItem;
    }
}