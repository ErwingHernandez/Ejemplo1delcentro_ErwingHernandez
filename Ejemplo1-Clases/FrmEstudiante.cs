﻿using System;
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
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerfExp() && VerfTitu())
            {
                DialogResult t = MessageBox.Show("¿Esta seguro que los datos estan correctos?", "Confirmar", MessageBoxButtons.YesNo);
                if (t == DialogResult.Yes)
                {
                    Datos.Alumnos.Add(new Alumno(textExperiencia.Text,textTitulacion.Text));
                    DialogResult r = MessageBox.Show("Se han ingresado Correctamente los datos", "Confirmar", MessageBoxButtons.OK);
                    Close();
                }

            }
            else
            {
                DialogResult r = MessageBox.Show("Porfavor LLene todo los campos", "Confirmar", MessageBoxButtons.OK);
            }
        }
        private bool VerfExp()
        {
            if (string.IsNullOrEmpty(textExperiencia.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool VerfTitu()
        {
            if (string.IsNullOrEmpty(textTitulacion.Text))
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
