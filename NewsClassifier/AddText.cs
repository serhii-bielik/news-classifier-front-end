using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsClassifier
{
    public partial class AddText : Form
    {
        public string text = String.Empty;
        public AddText(string txt = "")
        {
            InitializeComponent();
            txtInput.Text = txt;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            text = txtInput.Text;
            Close();
        }
    }
}
