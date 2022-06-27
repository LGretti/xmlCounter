using System.Xml;

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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Arquivos XML (*.xml)|*.xml";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string filepath in ofd.FileNames)
                {
                    txtArqs.Items.Add(filepath);

                    XmlTextReader xmlReader = new XmlTextReader(filepath);

                }
            }

        }

        private void frmContador_Load(object sender, EventArgs e)
        {

        }
    }
}