using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.ML;
//using namespace WPF_Sentiment_Analysis;



namespace WPF_Sentiment_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonNhapCau_Click(object sender, EventArgs e)
        {
            string sentence = TextBoxNhapCau.Text;
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Comment = sentence
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            string[] camxuc = {"", "Rất tiêu cực", "Tiêu cực", "Trung lập", "Tích cực", "Rất tích cực" };
            var Label = (int)result.PredictedLabel;
            LabelCamXuc.Text = "Cảm xúc: " + camxuc[Label];
            LabelDanhGia.Text = "Đánh giá: " + Label + "/5"; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
