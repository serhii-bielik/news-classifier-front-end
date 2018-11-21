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
    public partial class Main : Form
    {
        string textData = String.Empty;
        public Main()
        {
            InitializeComponent();
            comboM.SelectedIndex = 0;
        }

        private void btn_classify_Click(object sender, EventArgs e)
        {
            if (textData == String.Empty && 
                (numFrom.Value == 0 && numTo.Value == 0))
            {
                MessageBox.Show("Please specify input data", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                ClassifierManager cm;
                if (textData != String.Empty)
                    cm = new ClassifierManager(textData, comboM.SelectedIndex);
                else
                    cm = new ClassifierManager(numFrom.Value, numTo.Value, comboM.SelectedIndex);

                ClassificationResult result = null;
                try
                {
                    result = cm.Classify();
                }
                catch (Exception)
                {
                    MessageBox.Show("Server does not answering.", "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (result != null)
                {

                }
                else
                {
                    MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
