using System.Data.SqlClient;

namespace BarAppAdam
{
    public partial class MainForm : Form
    {
        private readonly SqlConnection _connection = new SqlConnection();
        public MainForm()
        {
            InitializeComponent();
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
            using var command = _connection.
        }
    }
}