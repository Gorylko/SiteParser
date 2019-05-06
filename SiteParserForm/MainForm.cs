using SiteParser.Core;
using SiteParser.Core.Habra;
using System;
using System.Windows.Forms;
using SiteParser.Core.KinoPoisk;

namespace SiteParserForm
{
    public partial class MainForm : Form
    {
        ParserWorker<string[]> parser;
        public MainForm()
        {
            InitializeComponent();
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
            switch(ComboBoxSites.SelectedItem.ToString())
            {
                case "Habra":
                    parser = new ParserWorker<string[]>(new HabraParser());
                    parser.Settings = new HabraSettings((int)NumericStart.Value, (int)NumericEnd.Value);
                    break;
                case "Kino":
                    parser = new ParserWorker<string[]>(new KinoParser());
                    parser.Settings = new KinoSettings();
                    break;
                default:
                    parser = new ParserWorker<string[]>(new HabraParser());
                    parser.Settings = new HabraSettings((int)NumericStart.Value, (int)NumericEnd.Value);
                    break;
            }

            parser.OnCompleted += Parser_OnComplited;
            parser.OnNewData += Parser_OnNewData;
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
