namespace DesignResponsivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void renderizaInterface()
        {

            int menuEsquerdo_Largura = 200, menuEsquerdo_Altura = menuEsquerdo.Height;
            int menuCima_Largura = menuEsquerdo.Width, menuCima_Altura = 200;


            WindowState = FormWindowState.Maximized;

            //Painel no meio da tela

            //Configuração menu esquerdo
            menuEsquerdo.Location = new Point(0, 0);
            menuEsquerdo.Size = new Size(200, ClientSize.Height);

            menuCima.Size = new Size(ClientSize.Width, 100);
            menuCima.Location = new Point(200, 0);

            panel1.Location = new Point(menuEsquerdo_Largura / 2 + ClientSize.Width / 2 - panel1.Size.Width / 2, ClientSize.Height / 2 - panel1.Size.Height / 2);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            renderizaInterface();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void menuEsquerdo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}