using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_7___Lists_WinForms
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(rng.Next(100));
            lstNumbers.DataSource = numbers;
            
            heroes.Add("superman");
            heroes.Add("batman");
            lstHeroes.DataSource = heroes;
        }

        private void btnSortNumbers_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            if (radDescending.Checked == true)
            {
                numbers.Reverse();
            }
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: numbers sorted.";
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            if (radDescending.Checked == true)
            {
                heroes.Reverse();
            }
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Status: heroes sorted.";
        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(rng.Next(100));
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: New numbers list created.";
            btnRemoveNumber.Enabled = true;
            btnRemoveAllNumbers.Enabled = true;
        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("superman");
            heroes.Add("batman");
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = "Status: New heroes list created.";
        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            lblStatus.Text = $"Status: {lstNumbers.SelectedItem} was removed from the list.";
            numbers.RemoveAt(lstNumbers.SelectedIndex);
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            if (numbers.Count() == 0)
            {
                btnRemoveNumber.Enabled = false;
                btnRemoveAllNumbers.Enabled = false;
                lblStatus.Text = "Status: Add new numbers before removing them.";
            }
        }

        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = "Status: Removed all numbers.";
            btnRemoveAllNumbers.Enabled = false;
            btnRemoveNumber.Enabled = false;
        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            if (heroes.Contains(txtRemoveHero.Text.Trim(), StringComparer.OrdinalIgnoreCase))
            {
                heroes.RemoveAll(n => Equals(txtRemoveHero.Text.Trim(), StringComparer.OrdinalIgnoreCase));
                lblStatus.Text = $"Status: {txtRemoveHero.Text.Trim()} was removed removed from the list.";
            }
            else
            {
                lblStatus.Text = "Status: Hero does is not on the list.";
            }
            txtRemoveHero.Text = "";
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            heroes.Add(txtAddHero.Text.Trim());
            lblStatus.Text = $"Status: {txtAddHero.Text.Trim()} was added to the list.";
            txtAddHero.Text = "";
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
        }

        private void chkToggleUpper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToggleUpper.Checked == true)
            {
                for (int i = 0; i <= heroes.Count() - 1; i++)
                {
                    heroes.Add(heroes.ElementAt(0).ToUpper());
                    heroes.RemoveAt(0);
                }
            }
            else
            {
                for (int i = 0; i <= heroes.Count() - 1; i++)
                {
                    heroes.Add(heroes.ElementAt(0).ToLower());
                    heroes.RemoveAt(0);
                }
            }
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
        }
    }
}
