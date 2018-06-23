using RegistroArticulosDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace RegistroArticulosDetalle.UI.Consultas
{
    public partial class cArticulos : Form
    {
        public cArticulos()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            Expression<Func<Articulos, bool>> filtro = a => true;
            int id;

            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0://Todos
                    break;
                case 1://ArticuloId                    
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.ArticuloId == id;
                    break;
                case 2://Descripcion
                    filtro = a => a.Descripcion.Contains(Criterio_textBox.Text);
                    break;
                case 3://Fecha Vencimiento
                    filtro = a => a.FechaVencimiento.Equals(Fecha_dateTimePicker.Value.Date);
                    break;
                case 4://Rango de Fecha
                    filtro = a => a.FechaVencimiento >= Desde_dateTimePicker.Value.Date && a.FechaVencimiento <= Hasta_dateTimePicker.Value.Date;
                    break;
                case 5://Descripcion y Rango Fecha
                    filtro = a => (a.Descripcion.Contains(Criterio_textBox.Text)) && (a.FechaVencimiento >= Desde_dateTimePicker.Value.Date && a.FechaVencimiento <= Hasta_dateTimePicker.Value.Date);
                    break;

            }
            Consulta_dataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro);
        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*Si seleccionamos el indice 0 se limpiar una busqueda anterior y deshabilita la busqueda
             * por criterio por rango y fecha, ademas buscamos automaticamente
             */
            if (Filtro_comboBox.SelectedIndex == 0)
            {
                Criterio_textBox.Clear();
                Criterio_textBox.Enabled = false;
                Fecha_dateTimePicker.Enabled = false;
                Desde_dateTimePicker.Enabled = false;
                Hasta_dateTimePicker.Enabled = false;
                Consultar_button.PerformClick();
            }
            else//como estas dos opciones usan el criterio textbox me parecio mas facil asi
            if (Filtro_comboBox.SelectedIndex == 1 || Filtro_comboBox.SelectedIndex == 2)
            {

                Fecha_dateTimePicker.Enabled = false;
                Desde_dateTimePicker.Enabled = false;
                Hasta_dateTimePicker.Enabled = false;
                Criterio_textBox.Enabled = true;
            }
            else
            //el indice 3 no visualiza el text de criterio sino que visualiza un calendario para 
            //elegir una fecha exacta
            if (Filtro_comboBox.SelectedIndex == 3)
            {

                Criterio_textBox.Enabled = false;
                Desde_dateTimePicker.Enabled = false;
                Hasta_dateTimePicker.Enabled = false;
                Fecha_dateTimePicker.Enabled = true;


            }
            else

            //Indice de rango de fecha

            if (Filtro_comboBox.SelectedIndex == 4)
            {
                Criterio_textBox.Enabled = false;
                Fecha_dateTimePicker.Enabled = false;
                Desde_dateTimePicker.Enabled = true;
                Hasta_dateTimePicker.Enabled = true;
            }
            else
            //inidice de descipcion y rango de fecha

            if (Filtro_comboBox.SelectedIndex == 5)
            {
                Fecha_dateTimePicker.Enabled = false;
                Criterio_textBox.Enabled = true;
                Desde_dateTimePicker.Enabled = true;
                Hasta_dateTimePicker.Enabled = true;
            }
        }

        private void Criterio_textBox_TextChanged(object sender, EventArgs e)
        {
            //buscamos automaticamente mientras vamos digitando
            if (Criterio_textBox.Text != string.Empty)
            {
                Consultar_button.PerformClick();

            }
        }
    }
}
