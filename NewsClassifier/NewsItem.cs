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
        public Image Status { get; set; }

        public NewsItem(int id, string text, string prediction, string trueLabels)
        {
            Id = id;
            Text = text;
            Prediction = prediction;
            TrueLabels = trueLabels;
            //TODO: Prediction Status
            //Status = (Guess == Answer) ? Resources.accept : Resources.cancel;
            Status = Resources.accept;
        }
    }
}
