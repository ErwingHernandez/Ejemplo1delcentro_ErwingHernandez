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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentro Centro = new FrmCentro();
            Centro.ShowDialog();
        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoadCentro Centro = new FrmLoadCentro();
            Centro.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfesor pro = new FrmProfesor();
            pro.ShowDialog();    
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmEstudiante est = new FrmEstudiante();
            est.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPersonal per = new FrmPersonal();
            per.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoadProfesor pro = new FrmLoadProfesor();
            pro.ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoadAlumnos alum = new FrmLoadAlumnos();
            alum.ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLoadPersonal per = new FrmLoadPersonal();
            per.ShowDialog();
        }
    }
}
