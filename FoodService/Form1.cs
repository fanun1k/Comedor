using Model;
namespace FoodService
{
    public partial class Form1 : Form
    {
        private readonly ClienteService clienteService;
        private cliente _cliente;
        public Form1(ClienteService _clienteService)
        {
            InitializeComponent();
            clienteService = _clienteService;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               
                List<cliente> clientes= clienteService.ObtenerTodos();   

                dgvClientes.AutoGenerateColumns = true;
                dgvClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
    }
}



