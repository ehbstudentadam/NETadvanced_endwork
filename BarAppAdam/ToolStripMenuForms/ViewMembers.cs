using BarAppAdam.Data;
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
    public partial class ViewMembers : Form
    {
        private readonly MemberRepository memberRepository = new();
        private int from = 0;
        private int to = 50;

        public ViewMembers()
        {
            InitializeComponent();
            dataGridView1.DataSource = memberRepository.GetAllFromTill(from, to);
            ShowRecordsFromTillLabel.Text = $"Showing records {from} - {to}";
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (from == 0)
            {
                return;
            }
            from -= 50;
            to -= 50;
            dataGridView1.DataSource = memberRepository.GetAllFromTill(from, to);
            ShowRecordsFromTillLabel.Text = $"Showing records {from} - {to}";
        }

        private void Next_Click(object sender, EventArgs e)
        {
            from += 50;
            to += 50;
            dataGridView1.DataSource = memberRepository.GetAllFromTill(from, to);
            ShowRecordsFromTillLabel.Text = $"Showing records {from} - {to}";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
