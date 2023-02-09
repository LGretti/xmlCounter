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

                try {
                    string valorTag = edtTag.Text;

                    if (valorTag == "") {
                        edtTag.Focus();
                        throw new Exception("Informe o nome da tag!");
                    }

                    foreach (var file in xmlFiles) {
                        XDocument xDoc = XDocument.Load(file);
                        int numeroNota = Int32.Parse(xDoc.Document.Element(valorTag).Value);
                        numeroNotaList.Add(numeroNota);
                        txtArqs.Items.Add(Path.GetFileName(file) + " - " + numeroNota);
                    }

                    numeroNotaList.Sort();
                    for (int i = 1; i < numeroNotaList.Count; i++) {
                        if (numeroNotaList[i] != numeroNotaList[i - 1] + 1) {

                            //MessageBox.Show("Número pulado na sequência: " + numeroNotaList[i - 1] + " -> " + numeroNotaList[i]);
                            txtDiv.Items.Add("Número pulado na sequência: " + numeroNotaList[i - 1] + " -> " + numeroNotaList[i]);
                            break;
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

        }

        private void frmContador_Load(object sender, EventArgs e)
        {

        }
    }
}