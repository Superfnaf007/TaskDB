using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskDB
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAgregarTarea frm = new FrmAgregarTarea();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el formulario de registro.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoTareas frm = new FrmListadoTareas();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el listado de tareas.\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
               "¿Desea salir de TaskDB?",
               "Confirmar",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
                Application.Exit();

        }
    }
}
