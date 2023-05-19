using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class FrmCentro : Form
    {
        public FrmCentro()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (VerfNom() && VerfDirec() && VerfTelf() && VerfEmail())
            {
                DialogResult t = MessageBox.Show("¿Esta seguro que los datos estan correctos?", "Confirmar", MessageBoxButtons.YesNo);
                {
                   
                    Datos.Centros.Add(new Centro(textNombre.Text,textDireccion.Text,textTelefono.Text,textEmail.Text));
                }
                if (t == DialogResult.Yes)
                {
                   
                    DialogResult r = MessageBox.Show("Se han ingresado Correctamente los datos", "Confirmar", MessageBoxButtons.OK);
                    Close();
                }
                
            }
            else
            {
                DialogResult r = MessageBox.Show("Porfavor LLene todo los campos","Confirmar",MessageBoxButtons.OK);
            }
            
        }
        private bool VerfNom()
        {
            if (string.IsNullOrEmpty(textNombre.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerfDirec()
        {
            if (string.IsNullOrEmpty(textDireccion.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerfTelf()
        {
            if (string.IsNullOrEmpty(textTelefono.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerfEmail()
        {
            if (string.IsNullOrEmpty(textEmail.Text))
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
        private void textNombre_TextChanged(object sender, EventArgs e)
        {  
        }

        private void textDireccion_TextChanged(object sender, EventArgs e)
        {  
        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
