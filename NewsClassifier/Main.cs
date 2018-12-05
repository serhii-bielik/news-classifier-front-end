using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsClassifier
{
    public partial class Main : Form
    {
        delegate void SetDoneCallback(ClassificationResult result);
        delegate void SetErrorCallback(string title, string error);

        string textData = String.Empty;
        public Main()
        {
            InitializeComponent();
            comboM.SelectedIndex = 0;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        ClassifierManager cm;
        private void btn_classify_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textData) && 
                (numFrom.Value == 0 && numTo.Value == 0))
            {
                error("Wrong Input", "Please specify input data");
            } 
            else if (numFrom.Value > numTo.Value)
            {
                error("Wrong Input", "Wrong articles range.");
            }
            else
            {
                labPrecision.Text = "-";
                labRecall.Text = "-";
                labF1.Text = "-";
                dataGridView1.DataSource = new List<NewsItem>();
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                picLoader.Show();
                labLoader.Show();
                labLoader.BringToFront();

                if (textData != String.Empty)
                    cm = new ClassifierManager(textData, comboM.SelectedIndex);
                else
                    cm = new ClassifierManager(numFrom.Value, numTo.Value, comboM.SelectedIndex);

                Thread main = new Thread(classify);
                main.Start();   
            }
        }

        private void classify()
        {
            cm.DoneDelegate = done;
            cm.ErrorDelegate = error;
            cm.Classify();
        }

        private void done(ClassificationResult result)
        {
            if (labPrecision.InvokeRequired)
            {
                SetDoneCallback d = new SetDoneCallback(done);
                Invoke(d, new object[] { result });
            }
            else
            {
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

                    groupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    picLoader.Hide();
                    labLoader.Hide();
                }
                else
                {
                    error("Error", "Something went wrong.");
                }
            }
        }
        private void error(string title, string message)
        {
            if (labPrecision.InvokeRequired)
            {
                SetErrorCallback d = new SetErrorCallback(error);
                Invoke(d, new object[] { title, message });
            }
            else
            {
                MessageBox.Show(message, title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                picLoader.Hide();
                labLoader.Hide();
            }
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            AddText add = new AddText(textData);
            add.ShowDialog(this);
            textData = add.text;
        }
    }
}
