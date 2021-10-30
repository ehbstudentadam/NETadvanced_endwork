using BarAppAdam.Data;
using BarAppAdam.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarAppAdam.ToolStripMenuForms
{
    public partial class EditMember : Form
    {
        private readonly MemberRepository memberRepository = new();

        public EditMember()
        {
            InitializeComponent();
        }

        private void UserIdButtonSearch_Click(object sender, EventArgs e)
        {
            UserIdButtonSearch.Enabled = false;
            string? id = UserIdTextBox.Text;
            if (id == null || !int.TryParse(id, out _))
            {
                MessageBox.Show("Invallid ID type.", "Invalid IDType", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UserIdButtonSearch.Enabled = true;
                return;
            }

            int memberId = Convert.ToInt32(id);
            Member? fromRepository = memberRepository.GetEntity(memberId);

            if (fromRepository == null)
            {
                MessageBox.Show("The Member id has not been registered yet.", "Wrong MemberID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserIdButtonSearch.Enabled = true;
                return;
            }

            EditMemberDetails editMemberDetails = new(fromRepository);
            editMemberDetails.Show();
            this.Close();
        }
    }
}
