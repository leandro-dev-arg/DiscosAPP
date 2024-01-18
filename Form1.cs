using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscosAPP
{
    public partial class frmDiscosApp : Form
{
        private List<Discos> listaDiscos;
        public frmDiscosApp()
        {
            InitializeComponent();
        }

        private void frmDiscosApp_Load(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            listaDiscos= negocio.listar();
            dgvDiscos.DataSource = listaDiscos;
            pcbDiscos.Load(listaDiscos[0].UrlImagen);
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos Seleccionado =(Discos)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(Seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pcbDiscos.Load(imagen);
            }
            catch (Exception ex)
            {

                pcbDiscos.Load("(“https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRuqKNTAK2agAe2tqc7_uKuIIEG74Ydj4FMrw&usqp=CAU”)");
            }
        }
    }
}
