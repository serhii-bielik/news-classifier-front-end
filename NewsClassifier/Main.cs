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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_classify_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;

            if (String.IsNullOrEmpty(textData) && 
                (numFrom.Value == 0 && numTo.Value == 0))
            {
                MessageBox.Show("Please specify input data", "Wrong Input", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    if (result != null)
                    {
                        List<NewsItem> news = new List<NewsItem>();

                        if (String.IsNullOrEmpty(textData))
                        {
                            labPrecision.Text = Math.Round(result.Precision, 4).ToString();
                            labRecall.Text = Math.Round(result.Recall, 4).ToString();
                            labF1.Text = Math.Round(result.F1, 4).ToString();

                            for (int i = 0; i < result.Predictions.Count; i++)
                            {
                                string prediction = String.Empty;
                                if (result.Predictions[i].Count != 0)
                                    prediction = string.Join(", ", result.Predictions[i]);

                                string trueLabels = String.Empty;
                                if (result.TrueLabels[i].Count != 0)
                                    trueLabels = string.Join(", ", result.TrueLabels[i]);

                                int correctPredictions = 0;
                                foreach (string pred in result.Predictions[i])
                                {
                                    if (result.TrueLabels[i].Contains(pred))
                                        correctPredictions++;
                                }

                                news.Add(new NewsItem(i + 1, result.Text[i], prediction, trueLabels, 
                                    correctPredictions, result.TrueLabels[i].Count));
                            }
                        } 
                        else
                        {
                            labPrecision.Text = "-";
                            labRecall.Text = "-";
                            labF1.Text = "-";

                            string prediction = String.Empty;
                            if (result.Predictions[0].Count != 0)
                                prediction = string.Join(", ", result.Predictions[0]);

                            news.Add(new NewsItem(1, result.SingleText, prediction, "-"));
                        }

                        dataGridView1.DataSource = news;
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.", "Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Server does not answering.\n" + ex.Message, 
                        "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            AddText add = new AddText(textData);
            add.ShowDialog(this);
            textData = add.text;
        }
    }
}
