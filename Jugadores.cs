using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3.Models;

namespace WinFormsApp3
{
    public partial class Jugadores : Form
    {
        public string tipo;
        public int id=0;


        public Jugadores()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (tipo == "N")
            {
                if (validaciones())
                {
                    Jugadore objJugador = new Jugadore();
                    objJugador.Nombre = txtNombre.Text;
                    objJugador.Alias = txtAlias.Text;
                    objJugador.Estado = "A";
                    GeneralContext.contextoGeneral.Jugadores.Add(objJugador);
                    GeneralContext.contextoGeneral.SaveChanges();
                    MessageBox.Show($"Se creó con éxito al jugador #{objJugador.Id}");
                }
            }
            else
            {

            }
        }

        private bool validaciones()
        {
            bool respuesta = true;

            if (txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe Llenar el Campo Nombre");
                txtNombre.Focus();
                respuesta = false;
            }

            if (txtAlias.Text.Trim().Length == 0)
            {
                MessageBox.Show("Debe Llenar el Campo Alias");
                txtAlias.Focus();
                respuesta = false;
            }
            else
            {
                int contador = GeneralContext.contextoGeneral.Jugadores.Where(x => x.Alias.Equals(txtAlias.Text) && x.Estado != "I").Count();
                if (contador > 0)
                {
                    MessageBox.Show("El alias ya esxite");
                    txtAlias.Focus();
                    respuesta = false;
                }

            }
            return respuesta;
            
        }
    }
}
