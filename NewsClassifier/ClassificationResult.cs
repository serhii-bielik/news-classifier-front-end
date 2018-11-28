using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsClassifier
{
    class ClassificationResult
    {
        [JsonProperty(PropertyName = "f1")]
        public double F1 { get; set; }

        [JsonProperty(PropertyName = "precision")]
        public double Precision { get; set; }

        [JsonProperty(PropertyName = "recall")]
        public double Recall { get; set; }

        [JsonProperty(PropertyName = "content-snapshots")]
        public IList<string> Text { get; set; }

        [JsonProperty(PropertyName = "content-snapshot")]
        public string SingleText { get; set; }

        [JsonProperty(PropertyName = "predictions")]
        public IList<IList<string>> Predictions { get; set; }

        [JsonProperty(PropertyName = "true-labels")]
        public IList<IList<string>> TrueLabels { get; set; }
    }
}
