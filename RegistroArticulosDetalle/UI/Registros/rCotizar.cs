using RegistroArticulosDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroArticulosDetalle.DAL;
using RegistroArticulosDetalle.BLL;

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
                return;
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

            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = Detalle;
            Total();
        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            if(DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                List<CotizarArticulosDetalle> Detalle = (List<CotizarArticulosDetalle>)DetalleDataGridView.DataSource;

                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                DetalleDataGridView.DataSource = null;
                DetalleDataGridView.DataSource = Detalle;

            }
        }

        private void rCotizar_Load(object sender, EventArgs e)
        {

        }

        private void Importe_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Precio_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Cantidad_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Importe();
        }
                
        private void Articulo_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Precio();
        }

        private void Total_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void DetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Traer el precio desde la entidad articulos
        private void Precio()
        {
            List<Articulos> articulos = BLL.ArticulosBLL.GetList(a => a.Descripcion == Articulo_comboBox.Text);
            foreach (var item in articulos)
            {
                Precio_numericUpDown.Value = item.Precio;
            }
        }

        //calcular el importe
        private void Importe()
        {
            if (Cantidad_numericUpDown.Value != 0 && Precio_numericUpDown.Value != 0)
            {
                Importe_numericUpDown.Value = BLL.CotizarArticulosBLL.CalcularImporte(Cantidad_numericUpDown.Value, Precio_numericUpDown.Value);
            }
            else
                Importe_numericUpDown.Value = 0;
        }

        //calcular el total de la cotizacion
        private void Total()
        {
            if (Importe_numericUpDown.Value != 0)
            {
                Total_numericUpDown.Value += BLL.CotizarArticulosBLL.CalcularTotal(Importe_numericUpDown.Value);
            }
        }

        //llenar el combobox con los datos de las entidades
        private void LLenaCombobox()
        {
            Repositorio<Personas> personas = new Repositorio<Personas>(new Contexto());
            Repositorio<Articulos> articulos = new Repositorio<Articulos>(new Contexto());

            Persona_comboBox.DataSource = personas.GetList(p => true);
            Persona_comboBox.ValueMember = "PersonaId";
            Persona_comboBox.DisplayMember = "Nombres";

            Articulo_comboBox.DataSource = articulos.GetList(a => true);
            Articulo_comboBox.ValueMember = "ArticuloId";
            Articulo_comboBox.DisplayMember = "Descripcion";

        }

        //llenar la entidad con los datos
        private CotizarArticulos LlenaClase()
        {
            CotizarArticulos cotizar = new CotizarArticulos();

            cotizar.CotizarId = Convert.ToInt32(Id_numericUpDown.Value);
            cotizar.Fecha = FechaCotizacion_dateTimePicker.Value.Date;
            cotizar.Total = Total_numericUpDown.Value;
            cotizar.Comentarios = Comentarios_textBox.Text;

            foreach (DataGridViewRow item in DetalleDataGridView.Rows)
            {
                cotizar.AgregarDetalle(
                    ToInt(item.Cells["Id"].Value),
                    ToInt(item.Cells["CotizarId"].Value),
                    ToInt(item.Cells["ArticuloId"].Value),
                    ToInt(item.Cells["PersonaId"].Value),
                    ToInt(item.Cells["Cantidad"].Value),
                    ToInt(item.Cells["Precio"].Value),
                    ToInt(item.Cells["Importe"].Value)
                    );
            }

            return cotizar;
        }

        //verificar que los campos esten llenos
        private bool Validar()
        {
            bool CamposVacios = false;

            if (Cantidad_numericUpDown.Value == 0)
            {
                ValidarErrorProvider.SetError(Cantidad_numericUpDown, "Cantidad de articulos vacia");
                CamposVacios = true;
            }

            if (DetalleDataGridView.RowCount == 0)
            {
                ValidarErrorProvider.SetError(DetalleDataGridView, "Datos Vacios para mostrar");
                CamposVacios = true;
            }

            if (string.IsNullOrWhiteSpace(Comentarios_textBox.Text))
            {
                ValidarErrorProvider.SetError(Comentarios_textBox, "Deje un comentario sobre esta cotizacion");
                CamposVacios = true;
            }

            return CamposVacios;
        }

        //convertir a entero
        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;
        }

        //llenar los campos del registro
        private void LlenaCampos(CotizarArticulos cotizar)
        {
            Id_numericUpDown.Value = cotizar.CotizarId;
            FechaCotizacion_dateTimePicker.Value = cotizar.Fecha;
            Total_numericUpDown.Value = cotizar.Total;
            Comentarios_textBox.Text = cotizar.Comentarios;

            DetalleDataGridView.DataSource = cotizar.Detalle;

            DetalleDataGridView.Columns["Id"].Visible = false;
            DetalleDataGridView.Columns["CotizarId"].Visible = false;
            DetalleDataGridView.Columns["ArticuloId"].Visible = false;
            DetalleDataGridView.Columns["PersonaId"].Visible = false;
        }


    }
}
