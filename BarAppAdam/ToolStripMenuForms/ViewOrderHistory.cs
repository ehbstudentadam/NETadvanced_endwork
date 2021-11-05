using BarAppAdam.Data;

namespace BarAppAdam
{
    public partial class ViewOrderHistory : Form
    {
        private readonly OrderRepository orderRepository = new();
        private int from = 0;
        private int to = 50;

        public ViewOrderHistory()
        {
            InitializeComponent();
            dataGridView1.DataSource = orderRepository.GetAllFromTill(from, to);
            ShowingFromTillLabel.Text = $"Showing records {from} - {to}";
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (from == 0)
            {
                return;
            }
            from -= 50;
            to -= 50;
            dataGridView1.DataSource = orderRepository.GetAllFromTill(from, to);
            ShowingFromTillLabel.Text = $"Showing records {from} - {to}";
        }

        private void Next_Click(object sender, EventArgs e)
        {
            from += 50;
            to += 50;
            dataGridView1.DataSource = orderRepository.GetAllFromTill(from, to);
            ShowingFromTillLabel.Text = $"Showing records {from} - {to}";
        }
    }
}
