using System;
using System.IO;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName fileName = new FrmFileName();
            fileName.ShowDialog();

            string getInput = txtInput.Text;

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }
        }
    }
}
