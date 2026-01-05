using DevComponents.DotNetBar;
using FoodService.Forms;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Text;

namespace FoodService
{
    public partial class ClientForm : Office2007RibbonForm
    {
        private readonly IServiceProvider _provider;
        //private Cliente cliente;
        //private MenuForm menu;
        private SnackForm snack;
        //private TicketTurno ticket;


        public ClientForm(IServiceProvider provider)
        {
            /*Visible = false;
            Log.Info("Verificando la coneccion con la Base de Datos");
            if (!DbHelper.DatabaseIsReady())
            {
                Log.Info("No se puede conectar con la Base de Datos");
                MessageBox.Show("No se puede conectar con la Base de datos!!\n\r\n\r Verifique la conexion con el servidor, El sistema se cerrara automaticamente. ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }

            Log.Info("Se conecto Correctamente a la Base de datos");
            bool automaticUpdate = Property.GetBool(Property.SYSTEM_CLIENT_UPDATEONSTART) ?? false;
            if (automaticUpdate)
            {
                string filename = Property.GetString(Property.SYSTEM_CLIENT_FILEUPDATE);
                UpdateClientList(filename);
            }*/

            InitializeComponent();
            _provider = provider;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            //menu = new MenuForm(orderPanel);
            //menu.MdiParent = this;
           // ticket = new TicketTurno();
            snack = _provider.GetRequiredService<SnackForm>();
            snack.MdiParent = this;
            snack.Init(orderPanel, SnackForm.AUTOMATICO);
            snack.Visible = true;
            Visible = true;
            //Hide();
            //ShowInputCode();


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            /* if (menu == null)
             {
                 menu = new MenuForm(orderPanel);
                 menu.MdiParent = this;
             }
             snack.Hide();
             menu.Show();
             menu.Activate();*/
        }

        private void orderPanel_FinalizeOrder(object sender, EventArgs ca)
        {
            /* frm_InputCode form = new frm_InputCode(frm_InputCode.UseType.SNACK);
             form.MaxDigit = 4;
             form.TopMost = false;
             form.VerifyTurno = false;
             DateTime fecha = orderPanel.Date.Date;
             TimeSpan hora = DbHelper.GetDate().Value.TimeOfDay;

             if (form.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
             {
                 cliente = form.Cliente;
                 if (cliente != null)
                 {
                     string info = string.Format("{0} [CODIGO={1:0000}]", orderPanel.Date.ToString("dd/MM/yyyy"), cliente.Codigo);
                     info += Environment.NewLine;
                     info += string.Format("{0} {1} {2}", cliente.Paterno, cliente.Materno, cliente.Nombre);

                     try
                     {
                         List<Snack> items = new List<Snack>();
                         Orden orden = new Orden();
                         DateTime fechaDB = DbHelper.GetDate().Value;
                         orden.Fecha = fechaDB.Date;
                         orden.Hora = fechaDB.TimeOfDay;
                         orden.Monto = 0;
                         orden.Descuento = 0;
                         orden.Cliente = cliente;
                         orden.Estado = "EN PROCESO";
                         orden.Save();
                         info += Environment.NewLine + "Orden Nº" + orden.Id;
                         info += Environment.NewLine;

                         double total = 0;
                         foreach (OrderItemControl o in orderPanel.Items)
                         {
                             Snack reg = new Snack();
                             reg.Cliente = cliente;
                             reg.Fecha = fecha;
                             reg.Hora = hora;
                             reg.Item = o.Item;
                             reg.Precio = o.Price;
                             reg.Cantidad = o.Quantity;
                             reg.Total = o.Price * o.Quantity;
                             total += reg.Total;
                             if (snack.Tipo == 2)
                                 reg.Tipo = snack.Tipo.ToString();
                             else
                             {
                                 if (form.Source == SourceType.CARD)
                                     reg.Tipo = 1.ToString();
                                 else
                                     reg.Tipo = 0.ToString();
                             }

                             reg.Estado = Estado.ACTIVO;
                             reg.Orden = orden;
                             reg.Save();
                             items.Add(reg);
                             info += Environment.NewLine;
                             info += string.Format("{0} {1} {2}", reg.Cantidad, reg.Item.Nombre, reg.Precio, reg.Total);
                         }

                         orden.Monto = total;
                         orden.Estado = "ENTREGADO";
                         orden.Save();

                         orderPanel.Clear();
                         snack.SelectAll(false);
                         if (snack.Tipo == SnackForm.AUTOMATICO)
                         {
                             ticket.Nombre = string.Format("{0} {1}, {2}", cliente.Paterno, cliente.Materno, cliente.Nombre);
                             ticket.Codigo = Convert.ToInt32(cliente.Codigo);
                             ticket.Fecha = DbHelper.GetDate().Value;
                             ticket.Items = items;
                             ticket.Tipo = TicketTurno.SNACK;
                             ticket.Orden = orden;
                             ticket.Source = form.inputType;
                             ticket.prepare();
                             ticket.Print();
                         }
                         snack.RegisterInfo(info);
                     }
                     catch
                     {
                         snack.RegisterInfo("Error al guardar los datos [" + cliente.Codigo + "]");
                     }

                 }
             }
             else
             {

             }*/
        }

        public void ShowInputCode()
        {
            /*  cliente = null;
              lblName.Text = "_______________";
              lblLastName.Text = "_______________";
              lblDocument.Text = "__________";
              lblCode.Text = "________";
              GrayScreen screen = new GrayScreen();
              screen.TopMost = false;
              screen.Show();
              frm_InputCode form = new frm_InputCode(frm_InputCode.UseType.ASISTENCIA);
              form.MaxDigit = 10;
              form.TopMost = false;
              if (form.ShowDialog(screen) == System.Windows.Forms.DialogResult.OK)
              {
                  cliente = null;//form.User;
                  if (cliente != null)
                  {
                      lblName.Text = cliente.Nombre;
                      lblLastName.Text = string.Format("{0} {1}", cliente.Paterno, cliente.Materno);
                      lblDocument.Text = "";
                      lblCode.Text = string.Format("{0:0000}", cliente.Codigo);
                  }
              }
              ribbonBar1.Refresh();*/
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            /* if (snack == null)
             {
                 snack = new SnackForm(orderPanel, SnackForm.MANUAL);
                 snack.MdiParent = this;
             }
             //menu.Hide();
             snack.Show();
             snack.Activate();*/
        }

        private void snack_Click(object sender, EventArgs e)
        {
            /* if (snack == null || snack.Tipo != SnackForm.AUTOMATICO)
             {
                 orderPanel.Clear();
                 snack = new SnackForm(orderPanel, SnackForm.AUTOMATICO);
             }
             //menu.Hide();
             snack.MdiParent = this;
             snack.Show();
             snack.Activate();*/
        }

        private void comedor_Click(object sender, EventArgs e)
        {
            /*GrayScreen screen = new GrayScreen();
            screen.TopMost = false;
            screen.Show();
            frm_InputCode form = new frm_InputCode(frm_InputCode.UseType.COMEDOR);
            form.MaxDigit = 4;
            form.TopMost = false;
            if (form.ShowDialog(screen) == System.Windows.Forms.DialogResult.OK)
                return;
            screen.Close();*/
        }

        private void asistencia_Click(object sender, EventArgs e)
        {
            /*GrayScreen screen = new GrayScreen();
            screen.TopMost = false;
            screen.Show();
            frm_InputCode form = new frm_InputCode(frm_InputCode.UseType.ASISTENCIA);
            form.MaxDigit = 2;
            form.TopMost = false;
            if (form.ShowDialog(screen) == System.Windows.Forms.DialogResult.OK)
                return;
            screen.Close();*/
        }

        private void btn_snackManual_Click(object sender, EventArgs e)
        {
            //menu.Hide();
            /* orderPanel.Clear();
             if (snack == null || snack.Tipo != SnackForm.MANUAL)
                 snack = new SnackForm(orderPanel, SnackForm.MANUAL);
             snack.MdiParent = this;
             snack.Show();*/
        }

        private void btn_rsnack_Click(object sender, EventArgs e)
        {

        }

        private void btn_reporte_general_Click(object sender, EventArgs e)
        {
            /* FormReporteGeneral form = new FormReporteGeneral();
             form.ShowDialog(this);*/
        }

        private void btn_actualizarlistacomensales_Click(object sender, EventArgs e)
        {
            /*bool automaticUpdate = Property.GetBool(Property.SYSTEM_CLIENT_UPDATEONSTART) ?? false;
            if (automaticUpdate)
            {
                string filename = Property.GetString(Property.SYSTEM_CLIENT_FILEUPDATE);
                UpdateClientList(filename, true);
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    UpdateClientList(dialog.FileName);
            }*/
        }

        private void UpdateClientList(string filename)
        {
            UpdateClientList(filename, false);
        }

        private void UpdateClientList(string filename, bool showMessage)
        {
            /*Log.Info("Actualizando la lista de comensales");
            try
            {
                if (!File.Exists(filename))
                {
                    if (showMessage)
                    {
                        MessageBox.Show(this, "No se logro actualizar la lista de comensales!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Log.Error("Error al actualizar la lista de comenzales.");
                    }
                    return;
                }
                List<string>[] response = Cliente.LoadFileToDataBase(filename);
                List<string> result = response[0].Union(response[1]).ToList();
                List<string> list = Cliente.ListOfActivos();
                list = list.Except(result).ToList();
                Log.Info("La lista de comensales se actualizo correctamente.");
                string mensaje = string.Format("La lista de comensales se actualizo correctamente!!\n\r NUEVOS = {0}, ACTUALIZADOS= {1}, BAJA = {2}",
                                 response[0].Count, response[1].Count, list.Count);
                if (showMessage)
                    MessageBox.Show(this, mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                Log.Error("Error al actualizar la lista de comenzales.");
                if (showMessage)
                    MessageBox.Show(this, "No se logro actualizar la lista de comensales!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }*/
        }



        private void btn_backup_Click(object sender, EventArgs e)
        {
            //GenerarBackup(true);
        }

        private void GenerarBackup()
        {
            //GenerarBackup(false);
        }

        /*private void GenerarBackup(bool showMessage)
        {
            Log.Info("Generando un backup de la Base de Datos");
            string filename = string.Format(@"d:\{0}.bck", DateTime.Now.ToString("yyyyMMddHHmmss"));
            if (DbHelper.DoBackup("food_service", filename))
            {
                Log.Info("EL BACKUP DE LA BASE DE DATOS SE GENERO CORRECTAMENTE!!");
                if (showMessage)
                    MessageBox.Show(this, "EL BACKUP DE LA BASE DE DATOS SE GENERO CORRECTAMENTE!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Log.Error("OCURRIO UN PROBLEMA AL GENERAR EL BACKUP DE LA BASE DE DATOS!!");
                if (showMessage)
                    MessageBox.Show(this, "OCURRIO UN PROBLEMA AL GENERAR EL BACKUP DE LA BASE DE DATOS!!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }*/

        private void btn_editTicket_Click(object sender, EventArgs e)
        {
            /*FormEditTicket form = new FormEditTicket();
            form.Visible = true;*/
        }

        private void btn_listSnack_Click(object sender, EventArgs e)
        {
            /*FormSnackList form = new FormSnackList();
            form.InitializeValues();
            form.ShowDialog(this);*/
        }

        private void btn_listSeccion_Click(object sender, EventArgs e)
        {
            /*FormSeccionList form = new FormSeccionList();
              form.ShowDialog(this);*/
        }

        private void orderPanel_Load(object sender, EventArgs e)
        {

        }
    }
}

