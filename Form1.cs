using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace xmlCounter {
    public partial class frmContador : Form {
        public frmContador() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            Boolean inc = false;

            label4.ForeColor = label1.ForeColor;
            txtArqs.Items.Clear();
            txtDiv.Items.Clear();

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
                        XElement xDoc = XElement.Load(file);
                        string textoXml = xDoc.ToString();

                        int positionInitial = textoXml.IndexOf($"<{valorTag}>");
                        int positionFinal = textoXml.IndexOf($"</{valorTag}>");

                        int lenght = positionFinal - positionInitial;

                        if (positionInitial != -1 && positionFinal != -1) {
                            string aa = textoXml.Substring(positionInitial + 5, lenght-5);
                            int numeroNota = int.Parse(aa);
                            numeroNotaList.Add(numeroNota);
                            txtArqs.Items.Add(Path.GetFileName(file) + " - " + numeroNota);
                        }
                    }

                    numeroNotaList.Sort();
                    for (int i = 1; i < numeroNotaList.Count; i++) {
                        if ((numeroNotaList[i] != numeroNotaList[i - 1] + 1) || (numeroNotaList[i] != numeroNotaList[i + 1] - 1)) {

                            int valor = 0;

                            if (numeroNotaList[i] != numeroNotaList[i - 1] + 1) {

                                valor = numeroNotaList[i - 1] + 1;

                            } else if (numeroNotaList[i] != numeroNotaList[i + 1] - 1) {

                                valor = numeroNotaList[i + 1] - 1;

                            }
                            inc = true;
                            label4.ForeColor = Color.Red;
                            txtDiv.Items.Add("Número pulado na sequência: " + valor);
                        }
                    }

                    if (!inc) {
                        txtDiv.Items.Add("Tudo certo!");
                    }

                } catch (Exception ex) {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

        }

        private void frmContador_Load(object sender, EventArgs e) {
            txtArqs.Enabled= true;
            txtDiv.Enabled= true;
        }
    }
}