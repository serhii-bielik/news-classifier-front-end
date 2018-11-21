﻿using Newtonsoft.Json;
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

        [JsonProperty(PropertyName = "predictions")]
        public IList<string> Predictions { get; set; }

        [JsonProperty(PropertyName = "true-labels")]
        public IList<string> TrueLabels { get; set; }
    }
}