using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerfUni() && VerfCate())
            {
                DialogResult t = MessageBox.Show("¿Esta seguro que los datos estan correctos?", "Confirmar", MessageBoxButtons.YesNo);
                if (t == DialogResult.Yes)
                {
                    
                     Datos.Personanles.Add(new Personal(textUnidad.Text,textCategoria.Text));
                    
                    DialogResult r = MessageBox.Show("Se han ingresado Correctamente los datos", "Confirmar", MessageBoxButtons.OK);
                    Close();
                }

            }
            else
            {
                DialogResult r = MessageBox.Show("Porfavor LLene todo los campos", "Confirmar", MessageBoxButtons.OK);
            }
        }
        private bool VerfUni()
        {
            if (string.IsNullOrEmpty(textUnidad.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerfCate()
        {
            if (string.IsNullOrEmpty(textCategoria.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de que quiere salir?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
