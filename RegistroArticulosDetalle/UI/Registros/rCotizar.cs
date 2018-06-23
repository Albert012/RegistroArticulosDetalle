using RegistroArticulosDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroArticulosDetalle.UI.Registros
{
    public partial class rCotizar : Form
    {
        public rCotizar()
        {
            InitializeComponent();
            LLenaCombobox();
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Id_numericUpDown.Value = 0;
            FechaCotizacion_dateTimePicker.ResetText();
            Cantidad_numericUpDown.Value = 0;
            Precio_numericUpDown.Value = 0;
            Importe_numericUpDown.Value = 0;
            Total_numericUpDown.Value = 0;
            Comentarios_textBox.Clear();
            DetalleDataGridView.DataSource = null;
            ValidarErrorProvider.Clear();
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            CotizarArticulos articulo;
            bool paso = false;

            if(Validar())
            {
                MessageBox.Show("Hay campos que deben ser llenados", "Fallo En La Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            articulo = LlenaClase();

            if (Id_numericUpDown.Value == 0)
                paso = BLL.CotizarArticulosBLL.Guardar(articulo);
            else
                paso = BLL.CotizarArticulosBLL.Modificar(articulo);

            if (paso)
            {
                Nuevo_button.PerformClick();
                MessageBox.Show("Guardado Correctamente!!", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se puede Guardar!!", "Fallo al Guardar!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void Eliminar_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Id_numericUpDown.Value);

            if (BLL.CotizarArticulosBLL.Eliminar(id))
                MessageBox.Show("Eliminado Correctamente!!", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo Eliminar!!", "Fallo al Eliminiar!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Id_numericUpDown.Value);
            CotizarArticulos articulo = BLL.CotizarArticulosBLL.Buscar(id);


            if (articulo != null)
            {
                LlenaCampos(articulo);
            }
            else
                MessageBox.Show("No hay resultados!!", "Busqueda Fallida!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void Agregar_button_Click(object sender, EventArgs e)
        {
            List<CotizarArticulosDetalle> Detalle = new List<CotizarArticulosDetalle>();
            
            if(DetalleDataGridView.DataSource != null)
            {
                Detalle = (List<CotizarArticulosDetalle>)DetalleDataGridView.DataSource;
            }

            Detalle.Add(new CotizarArticulosDetalle(
                id: 0,
                cotizarId: (int)Id_numericUpDown.Value,
                articuloId: (int)Articulo_comboBox.SelectedValue,
                personaId: (int)Persona_comboBox.SelectedValue,
                cantidadCotizada: (int)Cantidad_numericUpDown.Value,
                precio: (int)Precio_numericUpDown.Value,
                importe: (int)Importe_numericUpDown.Value
                ));

        }
    }
}
