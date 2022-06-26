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
            fbdXML.ShowDialog(this);
        }

        private void frmContador_Load(object sender, EventArgs e)
        {

        }
    }
}