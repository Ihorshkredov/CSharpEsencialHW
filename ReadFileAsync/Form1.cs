using System.Threading;

namespace ReadFileAsync
{
    public partial class Form1 : Form
    {
        private string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files | *.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtBoxPath.Text = openFile.FileName;
                btnRead.Enabled = true;
                path = openFile.FileName;
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRead.Enabled = false;
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {

            if (File.Exists(path) == true)
            {
                try
                {
                    string fileText = string.Empty;
                    //txtBoxFileText.Text = File.ReadAllTextAsync(path).Result;
                    await Task.Run(() =>
                     {
                         fileText = File.ReadAllTextAsync(path).Result;
                     });

                    txtBoxFileText.Text = fileText;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Read error");

                }

            }

        }
    }
}