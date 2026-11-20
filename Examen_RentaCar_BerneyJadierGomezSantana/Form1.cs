namespace Examen_RentaCar_BerneyJadierGomezSantana
{
    public partial class frmAlquiler : Form
    {
        public frmAlquiler()
        {
            InitializeComponent();

        }
        decimal subtotal = 0;
        decimal tarifa;
        decimal tarifaDiaria;
        decimal totalLinea;
        decimal descuento;
        decimal domicilio;
        decimal baseImponible;
        decimal itbis;
        decimal total;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtVehiculo.Clear();
            txtTarifa.Clear();

            dtpSalida.Value = DateTime.Today;

            nudDias.Value = 1;

            chkCorporativo.Checked = false;
            chkGps.Checked = false;

            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            subtotal = 0;

            lblEncabezado.Text =
                "Días".PadRight(6) +
                "Vehículo".PadRight(24) +
                "Tarifa".PadLeft(10) +
                "Total".PadLeft(12);

            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";

            txtCliente.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
          "¿Estas seguro de que desea salir?",
          "Confirmar salida",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar cliente
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Ingrese el cliente");
                return;
            }

            // Validar vehiculo
            if (txtVehiculo.Text == "")
            {
                MessageBox.Show("Ingrese el vehiculo");
                return;
            }

            // Validar tarifa
            if (!decimal.TryParse(txtTarifa.Text, out tarifa) || tarifa <= 0)
            {
                MessageBox.Show("Ingrese un tarifa valida");
                return;
            }

            // Calcular tarifa diaria
            tarifaDiaria = tarifa;

            if (rbtCompleto.Checked)
            {
                tarifaDiaria += 300;
            }

            if (chkGps.Checked)
            {
                tarifaDiaria += 100;
            }

            // Calcular total de linea
            totalLinea = tarifaDiaria * nudDias.Value;

            // Mostrar vehiculo
            string vehiculo = txtVehiculo.Text;

            if (chkGps.Checked)
                vehiculo += " (GPS)";
            else if (rbtCompleto.Checked)
                vehiculo += " (Completo)";
            else
                vehiculo += " (Basico)";

            string linea =
                nudDias.Value.ToString().PadRight(6) +
                vehiculo.PadRight(24) +
                tarifaDiaria.ToString("N2").PadLeft(10) +
                totalLinea.ToString("N2").PadLeft(12);

            lstAlquileres.Items.Add(linea);

            // Acumular subtotal
            subtotal += totalLinea;

            lblSubtotal.Text = "RD$ " + subtotal.ToString("N2");

            // Limpiar controles del vehiculo
            txtVehiculo.Clear();
            txtTarifa.Clear();

            nudDias.Value = 1;

            rbtBasico.Checked = true;
            chkGps.Checked = false;

            txtVehiculo.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstAlquileres.Items.Count == 0)
            {
                MessageBox.Show("No hay vehiculos agregados");
                return;
            }

            // Descuento corporativo
            descuento = 0;

            if (chkCorporativo.Checked)
            {
                descuento = subtotal * 0.15m;
            }

            // Entrega a domicilio
            domicilio = 0;

            if (rbtDomicilio.Checked)
            {
                domicilio = 500;
            }

            // Base imponible
            baseImponible = subtotal - descuento + domicilio;

            // ITBIS
            itbis = baseImponible * 0.18m;

            // Total
            total = baseImponible + itbis;

            // Mostrar resultados
            lblSubtotal.Text = "RD$ " + subtotal.ToString("N2");

            lblDescuento.Text = "RD$ " + descuento.ToString("N2");

            lblDomicilio.Text = "RD$ " + domicilio.ToString("N2");

            lblItbis.Text = "RD$ " + itbis.ToString("N2");

            lblTotal.Text = "RD$ " + total.ToString("N2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtVehiculo.Clear();
            txtTarifa.Clear();

            dtpSalida.Value = DateTime.Today;

            nudDias.Value = 1;

            chkCorporativo.Checked = false;
            chkGps.Checked = false;

            rbtBasico.Checked = true;
            rbtSucursal.Checked = true;

            lstAlquileres.Items.Clear();

            subtotal = 0;

            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblDomicilio.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";

            txtCliente.Focus();
        }

        private void grpSeguro_Enter(object sender, EventArgs e)
        {

        }
    }
}
