using Model;
namespace FoodService
{
    public partial class Form1 : Form
    {
        private readonly Cliente _clientes;
        public Form1(Cliente clientes)
        {
            InitializeComponent();
            _clientes = clientes;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
               
                var lista = _clientes.ObtenerTodos();

                dgvClientes.AutoGenerateColumns = true;
                dgvClientes.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
    }
}



