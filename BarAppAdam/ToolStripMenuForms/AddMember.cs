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

namespace BarAppAdam
{
    public partial class AddMember : Form
    {
        private readonly MemberRepository memberRepository = new();

        public AddMember()
        {
            InitializeComponent();
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            if (Emailtextbox.Text == "")
            {
                MessageBox.Show("Email must be filled in. Will be used to send inqueries and balances.", "Email empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (FirstNameTextbox.Text == "" || LastNameTextbox.Text == "" || StreetnameTextbox.Text == "" || NrTextbox.Text == "" || ZipcodeTextbox.Text == "" || CityTextbox.Text == "" || CountryTextbox.Text == "")
            {
                MessageBox.Show("Information not complete.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StringBuilder sb = new($"{StreetnameTextbox.Text.ToLower()} {NrTextbox.Text.ToLower()} {ZipcodeTextbox.Text.ToLower()} {CityTextbox.Text.ToLower()} {CountryTextbox.Text.ToLower()}");
            string firstName = FirstNameTextbox.Text.ToLower();
            string lastName = LastNameTextbox.Text.ToLower();
            string address = sb.ToString();
            string email = Emailtextbox.Text.ToLower();
            bool isOwner = IsOwnerCheckbox.Checked;

            Member member = new(firstName, lastName, address, email, isOwner);
            memberRepository.Save(member);
            this.Close();
        }
    }
}
