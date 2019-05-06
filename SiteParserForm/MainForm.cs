using SiteParser.Core;
using SiteParser.Core.Habra;
using System;
using System.Windows.Forms;
using SiteParser.Core.KinoPoisk;
using SiteParser.Core.Vk;

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
                    parser.Settings = new KinoSettings(1, 1);
                    break;
                case "Vk":
                    parser = new ParserWorker<string[]>(new VkParser());
                    parser.Settings = new VkSettings(1, 1, TextBoxId.Text);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxSites_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(ComboBoxSites.SelectedItem.ToString() == "Vk")
            {
                labelId.Visible = true;
                TextBoxId.Visible = true;
                NumericStart.Visible = false;
                label1.Visible = false;
                NumericEnd.Visible = false;
                label2.Visible = false;
            }
            else
            {
                labelId.Visible = false;
                TextBoxId.Visible = false;
                NumericStart.Visible = true;
                label1.Visible = true;
                NumericEnd.Visible = true;
                label2.Visible = true;
            }
        }
    }
}
