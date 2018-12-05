using NewsClassifier.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsClassifier
{
    class NewsItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Prediction { get; set; }
        public string TrueLabels { get; set; }
        public string Match { get; set; }
        public Image Status { get; set; }

        public NewsItem(int id, string text, string prediction, string trueLabels, int correct = 0, int total = 0)
        {
            Id = id;
            Text = text;
            Prediction = prediction;
            TrueLabels = trueLabels;

            if (correct == 0)
                Status = Resources.cancel;
            else if (correct < total)
                Status = Resources.error;
            else
                Status = Resources.accept;

            if (correct == 0 && total == 0)
            {
                Match = "-";
                Status = Resources.accept;
            }
            else
            {
                Match = correct + "/" + total;
            }
        }
    }
}
