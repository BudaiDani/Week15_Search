using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexSearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Search()
        {
            string pattern = txtPattern.Text;
            string text = txtText.Text;
            foreach (Match m in Regex.Matches(text, pattern))
            {
                lstMatches.Items.Add(m);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstMatches.Items.Clear();
        }
    }
}
