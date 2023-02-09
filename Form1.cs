using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace xmlCounter
{
    public partial class frmContador : Form
    {
        public frmContador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                
                string[] xmlFiles = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.xml");

                List<int> numeroNotaList = new List<int>();

                foreach (var file in xmlFiles) {
                    XDocument xDoc = XDocument.Load(file);
                    int numeroNota = Int32.Parse(xDoc.Root.Element("NumeroNota").Value);
                    numeroNotaList.Add(numeroNota);
                }

                numeroNotaList.Sort();
                for (int i = 1; i < numeroNotaList.Count; i++) {
                    if (numeroNotaList[i] != numeroNotaList[i - 1] + 1) {
                        MessageBox.Show("N�mero pulado na sequ�ncia: " + numeroNotaList[i - 1] + " -> " + numeroNotaList[i]);
                        break;
                    }
                }
            }

        }

        private void frmContador_Load(object sender, EventArgs e)
        {

        }
    }
}