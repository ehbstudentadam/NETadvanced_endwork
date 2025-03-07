﻿using BarAppAdam.Data;
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
    public partial class EditMemberDetails : Form
    {
        private readonly MemberRepository memberRepository = new();
        private Member fromRepository;

        public EditMemberDetails(Member fromRepository)
        {
            InitializeComponent();
            this.fromRepository = fromRepository;
            LoadMemberIntoFields();
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            CheckAllChangesAndApply();
            AddAmountTextbox.Text = null;
            RemoveAmountTextbox.Text = null;
            LoadMemberIntoFields();
        }

        private bool CheckAllChangesAndApply()
        {
            if (FirstNameTextbox.Text == "" || LastNameTextbox.Text == "" || StreetnameTextbox.Text == "" || NrTextbox.Text == "" || ZipcodeTextbox.Text == "" || CityTextbox.Text == "" || CountryTextbox.Text == "" || Emailtextbox.Text == "")
            {
                MessageBox.Show("Information not complete.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (AddAmountTextbox.Text != null && decimal.TryParse(AddAmountTextbox.Text, out _))
            {
                decimal amount = Convert.ToDecimal(AddAmountTextbox.Text);
                fromRepository.Wallet += amount;
            }
            if (RemoveAmountTextbox.Text != null && decimal.TryParse(RemoveAmountTextbox.Text, out _))
            {
                decimal amount = Convert.ToDecimal(RemoveAmountTextbox.Text);
                fromRepository.Wallet -= amount;
            }
            if (fromRepository.FirstName != FirstNameTextbox.Text)
            {
                fromRepository.FirstName = FirstNameTextbox.Text;
            }
            if (fromRepository.LastName != LastNameTextbox.Text)
            {
                fromRepository.LastName = LastNameTextbox.Text;
            }
            //Paste all addressBoxes on form together to compare to Address string in DB.
            StringBuilder sb = new($"{StreetnameTextbox.Text.ToLower()} {NrTextbox.Text.ToLower()} {ZipcodeTextbox.Text.ToLower()} {CityTextbox.Text.ToLower()} {CountryTextbox.Text.ToLower()}");

            if (fromRepository.Address != sb.ToString())
            {
                fromRepository.Address = sb.ToString();
            }
            if (fromRepository.Email != Emailtextbox.Text)
            {
                fromRepository.Email = Emailtextbox.Text;
            }
            if (fromRepository.IsOwner != IsOwnerCheckbox.Checked)
            {
                fromRepository.IsOwner = IsOwnerCheckbox.Checked;
            }
            return true;
        }

        private void LoadMemberIntoFields()
        {
            FirstNameTextbox.Text = fromRepository.FirstName;
            LastNameTextbox.Text = fromRepository.LastName;

            string[] splitAddress = fromRepository.Address.Split(' ');

            StreetnameTextbox.Text = splitAddress[0];
            NrTextbox.Text = splitAddress[1];
            ZipcodeTextbox.Text = splitAddress[2];
            CityTextbox.Text = splitAddress[3];
            CountryTextbox.Text = splitAddress[4];
            Emailtextbox.Text = fromRepository.Email;
            IsOwnerCheckbox.Checked = fromRepository.IsOwner;
            BalanceLabel.Text = fromRepository.Wallet.ToString();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (CheckAllChangesAndApply())
            {
                AddAmountTextbox.Text = null;
                RemoveAmountTextbox.Text = null;
                LoadMemberIntoFields();
                memberRepository.Save(fromRepository);
                System.Threading.Thread.Sleep(1000);
                this.Close();
            }
            else return;            
        }
    }
}
