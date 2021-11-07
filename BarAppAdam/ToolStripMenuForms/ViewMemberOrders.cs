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
    public partial class ViewMemberOrders : Form
    {
        private readonly MemberRepository memberRepository = new();
        private readonly OrderRepository orderRepository = new();
        private Member? member;
        private readonly int rowCount = 10;
        private int offSet = 0;

        public ViewMemberOrders()
        {
            InitializeComponent();

            FirstNameTextbox.Enabled = false;
            LastNameTextbox.Enabled = false;
            WalletTextbox.Enabled = false;
        }

        private void SearchMemberButton_Click(object sender, EventArgs e)
        {
            string? id = MemberIDTextbox.Text;
            if (id == null || !int.TryParse(id, out _))                             //ID's are numbers. (int)
            {
                MessageBox.Show("Invallid ID type.", "Invalid IDType", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int memberId = Convert.ToInt32(id);
            member = memberRepository.GetEntity(memberId);

            if (member == null)                                                     //No ID found in DB
            {
                MessageBox.Show("The Member id has not been registered yet.", "Wrong MemberID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FirstNameTextbox.Text = member.FirstName;            
            LastNameTextbox.Text = member.LastName;
            WalletTextbox.Text = member.Wallet.ToString();

            if (member == null)
            {
                return;
            }
            dataGridView1.DataSource = orderRepository.GetAllFromMemberTill(rowCount, offSet, member.Id);
            ShowingFromTillLabel.Text = $"Showing last {rowCount + offSet} records";
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (offSet == 0 || member == null)
            {
                return;
            }
            offSet -= rowCount;
            dataGridView1.DataSource = orderRepository.GetAllFromMemberTill(rowCount, offSet, member.Id);
            ShowingFromTillLabel.Text = $"Showing last {rowCount + offSet} records";
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (member == null)
            {
                return;
            }
            offSet += rowCount;
            dataGridView1.DataSource = orderRepository.GetAllFromMemberTill(rowCount, offSet, member.Id);
            ShowingFromTillLabel.Text = $"Showing last {rowCount + offSet} records";
        }

        private void MemberIDTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchMemberButton.PerformClick();
            }
        }
    }
}
