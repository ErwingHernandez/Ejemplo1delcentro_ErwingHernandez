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
    public partial class FrmProfesor : Form
    {
        public FrmProfesor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerfINSS() && VerfSal())
            {
                DialogResult t = MessageBox.Show("¿Esta seguro que los datos estan correctos?", "Confirmar", MessageBoxButtons.YesNo);
                if (t == DialogResult.Yes)
                {

                     Datos.Profesores.Add(new Profesor(textINSS.Text,double.Parse(textSalario.Text)));
                    
                    DialogResult r = MessageBox.Show("Se han ingresado Correctamente los datos", "Confirmar", MessageBoxButtons.OK);
                    Close();
                }

            }
            else
            {
                DialogResult r = MessageBox.Show("Porfavor LLene todo los campos", "Confirmar", MessageBoxButtons.OK);
            }
        }
        private bool VerfINSS()
        {
            if (string.IsNullOrEmpty(textINSS.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerfSal()
        {
            if (string.IsNullOrEmpty(textSalario.Text))
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
    }
}
