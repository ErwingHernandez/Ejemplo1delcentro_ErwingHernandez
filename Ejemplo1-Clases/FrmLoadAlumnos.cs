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
    public partial class FrmLoadAlumnos : Form
    {
        public FrmLoadAlumnos()
        {
            InitializeComponent();
        }

        private void FrmLoadAlumnos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Datos.Alumnos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
