using RetiroDeMateriales.Entidades;
using RetiroDeMateriales.Factory;
using RetiroDeMateriales.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetiroDeMateriales.Presentaciones
{
    public partial class FrmNuevoRetiro : Form
    {
        private OrdenesRetiro orden;

        IServicio servicio;

        public FrmNuevoRetiro(FabricaServicio fabrica)
        {
            InitializeComponent();
            orden = new OrdenesRetiro();
            servicio = fabrica.CrearServicio();
        }

        private void FrmNuevoRetiro_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
            CargarComboBox(cboBoxMaterial, "Codigo", "Nombre", servicio.Materiales.Listar().ToArray());
            Limpiar();
        }

        private void Limpiar()
        {
            txtBoxResponsable.Text = String.Empty;
            dtpFecha.Value = DateTime.Now;
            dgvDetalles.Rows.Clear();
            cboBoxMaterial.SelectedIndex = -1;
            numCantidad.Value = 1;
        }

        private void CargarComboBox(ComboBox combo, string valorID, string valorDisplay, object[] objects)
        {
            combo.DataSource = objects;
            combo.ValueMember = valorID;
            combo.DisplayMember = valorDisplay;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool Validar()
        {
            if (dtpFecha.Value < DateTime.Today)
            {
                MessageBox.Show("Fecha no valida.", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtBoxResponsable.Text == String.Empty || txtBoxResponsable.Text.Length > 100)
            {
                MessageBox.Show("Responsable no valido.", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cboBoxMaterial.SelectedIndex == -1) 
            {
                MessageBox.Show("Material no valido", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #region Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Materiales material = (Materiales)cboBoxMaterial.SelectedItem;
                
                if (material.Stock - Convert.ToInt32(numCantidad.Value) < 0)
                {
                    MessageBox.Show($"Queda solamente {material.Stock} de este {material.Nombre}.", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (DataGridViewRow row in dgvDetalles.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == material.Codigo)
                    {
                        MessageBox.Show($"No se puede agregar dos veces el/la {material.Nombre}.", "VALIDACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                DetallesOrden detalle = new DetallesOrden();

                detalle.Material = material;
                detalle.Cantidad = Convert.ToInt32(numCantidad.Value);

                orden.AgregarDetalle(detalle);

                orden.Fecha = dtpFecha.Value;
                orden.Responsable = txtBoxResponsable.Text;

                dgvDetalles.Rows.Add(new object[] { detalle.Material.Codigo, detalle.Material.Nombre, detalle.Material.Stock, detalle.Cantidad, "Quitar" });
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            servicio.Ordenes.Agregar(orden);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region DataGrid

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                orden.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.RemoveAt(dgvDetalles.CurrentRow.Index);
            }
        }

        private void dgvDetalles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvDetalles.Rows.Count == 1)
            {
                btnAceptar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void dgvDetalles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvDetalles.Rows.Count == 0)
            {
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        #endregion

    }
}
