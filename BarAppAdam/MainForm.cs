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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginButton.Enabled = false;
            string? id = richTextBox1.Text;
            if (id == null || !int.TryParse(id, out _))
            {
                MessageBox.Show("Invallid ID type.", "Invalid IDType", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoginButton.Enabled = true;
                return;
            }

            int memberId = Convert.ToInt32(id);
            Member? fromRepository = memberRepositorty.GetEntity(memberId);

            if (fromRepository == null)
            {
                MessageBox.Show("The Member id has not been registered yet.", "Wrong MemberID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginButton.Enabled = true;
                return;
            }

            if (fromRepository.IsOwner)
            {
                menuStrip1.Show();
            }

            OrderWindow orderWindow = new();
            orderWindow.TopMost = true;
            orderWindow.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Exit application?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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

        private void LoadDatabaseForFirstTimeUse()
        {
            try
            {
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
                MessageBox.Show($"Drink database has been wrongly manipulated. Table will be truncated and reinitiated. ({e.Message})", "Manipulation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}