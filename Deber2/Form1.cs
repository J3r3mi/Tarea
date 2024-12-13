using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deber2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            string pais = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(pais))
            {
                // Agregar país al ListBox
                Lista.Items.Add(pais);

                // Limpiar el TextBox
                textBox1.Text = string.Empty;

                MessageBox.Show($"País '{pais}' agregado a la lista.", "Éxito");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre de país válido.", "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedItem != null)
            {
                string paisSeleccionado = Lista.SelectedItem.ToString();

                // Eliminar país del ListBox
                Lista.Items.Remove(paisSeleccionado);

                MessageBox.Show($"País '{paisSeleccionado}' eliminado de la lista.", "Éxito");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un país para eliminar.", "Error");
            }
        }
    }
    }

