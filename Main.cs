using System.IO.Pipes;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using IronOcr;

namespace Sirius_Sharp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void MSOpen_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OFDialog.ShowDialog(this);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OFDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string fileext = Path.GetExtension(OFDialog.FileName);
            TSFname.Text = fileext;
            //IF File is an image, run OCR
            if (fileext == ".png" || fileext == ".jpg" || fileext == ".jpeg")
            {
                toolStripStatusLabel1.Text = "Image File Detected";


                //Exception Handling
                try
                {
                    OCRPictureBox.Image = new Bitmap(OFDialog.FileName);
                    var OCR = new IronTesseract();


                    var OCRResult = OCR.Read(OCRPictureBox.Image);
                    if (OCRResult != null)
                    {
                        MainTextBox.Text = OCRResult.Text;
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(text: @"Error loading the image. " + exception.Message);
                }



            }

        }

        private void FExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }



        private void setWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_FileOK(object sender, EventArgs e)
        {



        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void TSProgbar_Click(object sender, EventArgs e)
        {

        }

        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            //--------------------------- SYNTAX HIGHLIGHTING ------------------------------------------------------------
            // getting keywords/functions
            string keywords = @"\b(public|private|partial|static|namespace|class|using|void|foreach|in)\b";
            MatchCollection keywordMatches = Regex.Matches(MainTextBox.Text, keywords);
            //Uppercase
            string keywordsup = @"\b(PUBLIC|PRIVATE|partial|static|namespace|class|using|void|foreach|in)\b";
            MatchCollection keywordMatchesup = Regex.Matches(MainTextBox.Text, keywordsup);

            // getting types/classes from the text 
            string types = @"\b(Console)\b";
            MatchCollection typeMatches = Regex.Matches(MainTextBox.Text, types);

            // getting comments (inline or multiline)
            string comments = @"(\/\/.+?$|\/\*.+?\*\/)";
            MatchCollection commentMatches = Regex.Matches(MainTextBox.Text, comments, RegexOptions.Multiline);

            // getting strings
            string strings = "\".+?\"";
            MatchCollection stringMatches = Regex.Matches(MainTextBox.Text, strings);

            // saving the original caret position + forecolor
            int originalIndex = MainTextBox.SelectionStart;
            int originalLength = MainTextBox.SelectionLength;
            Color originalColor = Color.Black;

            // MANDATORY - focuses a label before highlighting (avoids blinking)
            blinklabel.Focus();

            // removes any previous highlighting (so modified words won't remain highlighted)
            MainTextBox.SelectionStart = 0;
            MainTextBox.SelectionLength = MainTextBox.Text.Length;
            MainTextBox.SelectionColor = originalColor;

            // scanning...
            foreach (Match m in keywordMatches)
            {
                MainTextBox.SelectionStart = m.Index;
                MainTextBox.SelectionLength = m.Length;
                MainTextBox.SelectionColor = Color.Blue;
            }
            //Uppercase Keywords
            foreach (Match m in keywordMatchesup)
            {
                MainTextBox.SelectionStart = m.Index;
                MainTextBox.SelectionLength = m.Length;
                MainTextBox.SelectionColor = Color.Blue;
            }

            foreach (Match m in typeMatches)
            {
                MainTextBox.SelectionStart = m.Index;
                MainTextBox.SelectionLength = m.Length;
                MainTextBox.SelectionColor = Color.DarkCyan;
            }

            foreach (Match m in commentMatches)
            {
                MainTextBox.SelectionStart = m.Index;
                MainTextBox.SelectionLength = m.Length;
                MainTextBox.SelectionColor = Color.Green;
            }

            foreach (Match m in stringMatches)
            {
                MainTextBox.SelectionStart = m.Index;
                MainTextBox.SelectionLength = m.Length;
                MainTextBox.SelectionColor = Color.Brown;
            }

            // restoring the original colors, for further writing
            MainTextBox.SelectionStart = originalIndex;
            MainTextBox.SelectionLength = originalLength;
            MainTextBox.SelectionColor = originalColor;

            // giving back the focus
            MainTextBox.Focus();
            //---------------------- END OF SYNTAX HIGHLIGHTING ----------------------------------------------
        }

        private void fileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileExplorer f2 = new FileExplorer();
            f2.Show();

        }

        private void recognizeTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageRec r2 = new ImageRec();
            r2.Show();
        }
    }



}
