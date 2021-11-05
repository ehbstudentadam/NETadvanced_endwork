using BarAppAdam.Data;
using BarAppAdam.Entities;
using BarAppAdam.Entities.Drinks;
using BarAppAdam.ToolStripMenuForms;
using System.Data.SqlClient;

namespace BarAppAdam
{
    public partial class MainForm : Form
    {
        private readonly MemberRepository memberRepositorty = new();
        private readonly DrinkRepository drinkRepository = new();
        private Beer? beer;
        private Wine? wine;
        private Softdrink? softdrink;
        private Shot? shot;
        private Cocktail? cocktail;
        private Member? member;


        public MainForm()
        {
            InitializeComponent();
            LoadDatabaseForFirstTimeUse();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginButton.Enabled = false;                                            //Disable button to counter spamclicking
            string? id = IdTextbox.Text;
            if (id == null || !int.TryParse(id, out _))                             //ID's are numbers. (int)
            {
                MessageBox.Show("Invallid ID type.", "Invalid IDType", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginButton.Enabled = true;
                return;
            }

            int memberId = Convert.ToInt32(id);                                     //IdTextbox string -> int
            Member? fromRepository = memberRepositorty.GetEntity(memberId);         //Retrieve member from DB by ID

            if (fromRepository == null)                                             //No ID found in DB
            {
                MessageBox.Show("The Member id has not been registered yet.", "Wrong MemberID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginButton.Enabled = true;
                return;
            }

            if (fromRepository.IsOwner)                                             //Only owners have acces to advanced menu.
            {
                menuStrip1.Show();
            }

            OrderWindow orderWindow = new(fromRepository);
            orderWindow.TopMost = true;
            orderWindow.Show();
            orderWindow.Location = new Point((this.ClientSize.Width - orderWindow.Width) / 2, (this.ClientSize.Height - orderWindow.Height) / 2);
                                                                                    //Center the OrderForm (At least it worked on my screen...)
            orderWindow.FormClosed += Child_FormClosed;
        }

        private void Child_FormClosed(object? sender, FormClosedEventArgs e)        //Add this event to FormCosed event to re-enable button and allow use by other user
        {
            IdTextbox.Text = null;
            LoginButton.Enabled = true;
            menuStrip1.Hide();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)        //Only owners can close the program (Keyboard should only be accessible by owner)
        {
            DialogResult choice = MessageBox.Show(new Form { TopMost = true}, "Exit application?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (choice == DialogResult.Cancel)
            {
                return;
            }
            Application.Exit();
        }

        private void AddMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddMember>().Any())
            {
                Application.OpenForms.OfType<AddMember>().First().Show();
                return;
            }
            AddMember addMember = new();
            addMember.TopMost = true;
            addMember.Show();
        }

        private void OrderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ViewOrderHistory>().Any())
            {
                Application.OpenForms.OfType<ViewOrderHistory>().First().Show();
                return;
            }
            ViewOrderHistory viewOrderHistory = new();
            viewOrderHistory.TopMost = true;
            viewOrderHistory.Show();
        }

        private void MembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ViewMembers>().Any())
            {
                Application.OpenForms.OfType<ViewMembers>().First().Show();
                return;
            }
            ViewMembers viewMembers = new();
            viewMembers.TopMost = true;
            viewMembers.Show();
        }

        private void EditMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EditMember>().Any())
            {
                Application.OpenForms.OfType<EditMember>().First().Show();
                return;
            }
            EditMember editMember = new();
            editMember.TopMost = true;
            editMember.Show();
        }

        private void EditDrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EditDrink>().Any())
            {
                Application.OpenForms.OfType<EditDrink>().First().Show();
                return;
            }
            EditDrink editDrink = new();
            editDrink.TopMost = true;
            editDrink.Show();
        }

        private void LoadDatabaseForFirstTimeUse()                              //This will check Member Table, if empty AND if ID = 1 = "admin"
        {                                                                       //This will check Drink Table if empty AND if sequence is tampered with.
            try
            {                                                                   //Admin account on ID=1 is temporary could later be changed to other ID for safetyreasons.
                beer = (Beer?)drinkRepository.GetEntity(1);
                wine = (Wine?)drinkRepository.GetEntity(2);
                softdrink = (Softdrink?)drinkRepository.GetEntity(3);
                shot = (Shot?)drinkRepository.GetEntity(4);
                cocktail = (Cocktail?)drinkRepository.GetEntity(5);
                member = (Member?)memberRepositorty.GetEntity(1);
            }
            catch (System.InvalidCastException e)
            {
                drinkRepository.TruncateTable();
                MessageBox.Show($"Drink database has been wrongly manipulated. Table will be truncated and reinitiated. Original Prices will be set. {Environment.NewLine} ({e.Message})", "Manipulation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDatabaseForFirstTimeUse();
                return;
            }


            if (beer == null)
            {
                drinkRepository.Save(new Beer());                
            }
            if (wine == null)
            {
                drinkRepository.Save(new Wine());
            }
            if (softdrink == null)
            {
                drinkRepository.Save(new Softdrink());
            }
            if (shot == null)
            {
                drinkRepository.Save(new Shot());
            }
            if (cocktail == null)
            {
                drinkRepository.Save(new Cocktail());
            }
            if (member == null)
            {
                memberRepositorty.Save(new Member("admin", "admin", "admin 00 0000 admin admin", "admin", true));
                return;
            }
            if (member.FirstName != "admin")
            {
                memberRepositorty.Save(new Member("admin", "admin", "admin 00 0000 admin admin", "admin", true) { Id = 1 });
            }
        }

        private void IdTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginButton.PerformClick();
            }
        }
    }
}