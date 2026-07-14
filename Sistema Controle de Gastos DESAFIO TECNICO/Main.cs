using Sistema_Controle_de_Gastos_DESAFIO_TECNICO.Forms;

namespace Sistema_Controle_de_Gastos_DESAFIO_TECNICO
{
    public partial class FormMain : Form
    {
        public static Panel MainPanel;
        public FormMain()
        {
            InitializeComponent();
            MainPanel = panel1;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            FormMenu  FormMenu= new FormMenu();
            FormMenu.Dock = DockStyle.Fill;
            FormMenu.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(FormMenu);
            FormMenu.Show();
        }
    }
}
