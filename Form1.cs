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
            
            heroes.Add("Superman");
            heroes.Add("Batman");
            lstHeroes.DataSource = heroes;
        }
    }
}
