using SiteParser.Core;
using SiteParser.Core.Habra;
using System;
using System.Windows.Forms;

namespace SiteParserForm
{
    public partial class MainForm : Form
    {
        ParserWorker<string[]> parser;
        public MainForm()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(new HabraParser());

            parser.OnCompleted += Parser_OnComplited;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }

        private void Parser_OnComplited(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            parser.Settings = new HabraSettings((int)NumericStart.Value, (int)NumericEnd.Value);
            parser.Start();
        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }

        private void NumericStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
