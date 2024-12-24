using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3.Context;

namespace WinFormsApp3
{
    public partial class frmJuagadores : Form
    {
        public frmJuagadores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmJuagadores_Load(object sender, EventArgs e)
        {
            cargarJugadores();
        }

        private void cargarJugadores()
        {
            grdJugadores.DataSource = GeneralContext.contextoGeneral.Jugadores.Where(x => x.Nombre.Contains(txtFiltro.Text)).ToList();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargarJugadores();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Jugadores frm = new Jugadores();
            frm.tipo = "N";
            frm.ShowDialog();
            cargarJugadores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdJugadores.Rows.Count > 0)
            {
                int id = Convert.ToInt32( grdJugadores.CurrentRow.Cells[0].Value.ToString());
                int contador= GeneralContext.contextoGeneral.Equipos.Where(x => x.IdJugador==id && x.Estado!="I").Count();
                contador= contador+ GeneralContext.contextoGeneral.Posiciones.Where(x => x.IdJugador == id && x.Estado != "I").Count();

                if (contador == 0)
                {
                    var objJugador = GeneralContext.contextoGeneral.Jugadores.Find(id);
                    objJugador.Estado = "I";
                    GeneralContext.contextoGeneral.Jugadores.Update(objJugador);
                    GeneralContext.contextoGeneral.SaveChanges();
                    MessageBox.Show("El registro fue eliminado con éxito!");
                    cargarJugadores();
                }
                else
                {
                    MessageBox.Show("El registro ya se encuentra Usado");
                }

            }
        }
    }
}
