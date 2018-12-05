using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NewsClassifier
{
    class ClassifierManager
    {
        private string textData;
        private int modelId;
        private int newsFrom;
        private int newsTo;

        public Action<ClassificationResult> DoneDelegate { get; set; }
        public Action<string, string> ErrorDelegate { get; set; }

        public ClassifierManager(string textData, int modelId)
        {
            this.textData = textData;
            this.modelId = modelId;
        }

        public ClassifierManager(decimal newsFrom, decimal newsTo, int modelId)
        {
            this.newsFrom = Convert.ToInt32(newsFrom);
            this.newsTo = Convert.ToInt32(newsTo);
            this.modelId = modelId;
        }

        internal void Classify()
        {
            try
            {
                ClassificationResult result = null;
                string url = PrepareUrl();

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    result = JsonConvert.DeserializeObject<ClassificationResult>(json);
                }
                DoneDelegate?.Invoke(result);
            }
            catch (Exception ex)
            {
                ErrorDelegate?.Invoke("Request Error", ex.Message);
            }            
        }

        private string PrepareUrl()
        {
            //TODO: Request for raw text
            string url = "http://127.0.0.1:5000/";

            if (String.IsNullOrEmpty(textData))
            {
                url += @"test?start={FROM}&end={TO}&model-type={MODEL}";
                url = url.Replace("{FROM}", newsFrom.ToString()).Replace("{TO}", newsTo.ToString());
            } 
            else
            {
                url += @"doc-test?content={CONTENT}&model-type={MODEL}";
                url = url.Replace("{CONTENT}", System.Net.WebUtility.UrlEncode(textData));
            }       

            string model = String.Empty;
            switch (modelId)
            {
                case 0:
                    model = "mlp-base";
                    break;
                case 1:
                    model = "rnn-base";
                    break;
                case 2:
                    model = "mlp-optim";
                    break;
                case 3:
                    model = "rnn-optim";
                    break;
                case 4:
                    model = "rnn-overfit";
                    break;
            }

            url = url.Replace("{MODEL}", model);
            return url;
        }
    }
}
