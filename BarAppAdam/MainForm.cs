using BarAppAdam.Data;
using BarAppAdam.Entities;
using BarAppAdam.ToolStripMenuForms;
using System.Data.SqlClient;

namespace BarAppAdam
{
    public partial class MainForm : Form
    {
        private readonly MemberRepository memberRepositorty = new();


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //menuStrip1.Hide();
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
    }
}