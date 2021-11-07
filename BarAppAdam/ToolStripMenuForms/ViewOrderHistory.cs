using BarAppAdam.Data;

namespace BarAppAdam
{
    public partial class ViewOrderHistory : Form
    {
        private readonly OrderRepository orderRepository = new();
        private readonly int rowCount = 50;
        private int offSet = 0;

        public ViewOrderHistory()
        {
            InitializeComponent();
            dataGridView1.DataSource = orderRepository.GetLastXAmountSkipByX(rowCount, offSet);
            ShowingFromTillLabel.Text = $"Showing last {rowCount + offSet} records";
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (offSet == 0)
            {
                return;
            }
            offSet -= rowCount;
            dataGridView1.DataSource = orderRepository.GetLastXAmountSkipByX(rowCount, offSet);
            ShowingFromTillLabel.Text = $"Showing last {rowCount + offSet} records";
        }

        private void Next_Click(object sender, EventArgs e)
        {
            offSet += rowCount;
            dataGridView1.DataSource = orderRepository.GetLastXAmountSkipByX(rowCount, offSet);
            ShowingFromTillLabel.Text = $"Showing last {rowCount + offSet} records";
        }
    }
}
