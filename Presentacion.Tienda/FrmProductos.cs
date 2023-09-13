using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Tienda;
using LogicaNegocio.Tienda;

namespace Presentacion.Tienda
{
    public partial class FrmProductos : Form
    {
        private ProductosLogica _productosLogica;
        private string banderaGuardar = "";
        private int idproducto = 0;
        public FrmProductos()
        {
            InitializeComponent();
            _productosLogica = new ProductosLogica();
        }
        private void GuardarProducto()
        {
            Productos nuevoproductos = new Productos();
            nuevoproductos.Nombre= txtproducto.Text;
            nuevoproductos.Descripcion= txtdescripcion.Text;
            nuevoproductos.Precio = double.Parse(txtprecio.Text);
            var validar = _productosLogica.ValidarProductos(nuevoproductos);
            if(validar.Item1)
            {
                _productosLogica.GuardarProducto(nuevoproductos);
                LlenarUsuario();
                LimpiarTextBox();
                ControlarBotones(true, false, false, true, true);
                ControlCuadros(false);
            }
            else
                MessageBox.Show(validar.Item2, "Error de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ControlarBotones(Boolean nuevo, Boolean guardar, Boolean cancelar, Boolean cerrar, Boolean eliminar)
        {
            btnnuevo.Enabled = nuevo;
            btnguardar.Enabled = guardar;
            btncancelar.Enabled = cancelar;
            btnborrar.Enabled = eliminar;
            btnsalir.Enabled = cerrar;
        }
        private void ControlCuadros(Boolean estado)
        {
            txtproducto.Enabled = estado;
            txtdescripcion.Enabled = estado;
            txtprecio.Enabled = estado;
        }
        private void LlenarUsuario()
        {
            dtgProductos.DataSource = _productosLogica.ObtenerProductos();
        }
        private void LimpiarTextBox()
        {
            txtproducto.Text = "";
            txtdescripcion.Text = "";
            txtprecio.Text = "";
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ControlarBotones(true, false, false, true, true);
            ControlCuadros(false);
            LlenarUsuario();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ControlarBotones(false, true, true, false, false);
            ControlCuadros(true);
            txtproducto.Focus();
            banderaGuardar = "Guardar";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (banderaGuardar.Equals("Guardar"))
            {
                GuardarProducto();
            }
            else if (banderaGuardar.Equals("Modificar"))
            {
                
            }
        }
    }
}