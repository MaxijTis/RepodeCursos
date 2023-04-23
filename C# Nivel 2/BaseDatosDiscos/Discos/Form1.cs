using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionDB;
using clasesDominio;

namespace MainProyect
{
    public partial class frmMelómano : Form
    {
        //private List<Discos> listadisco;
        public frmMelómano()
        {
            InitializeComponent();
        }

        private void Melómano_Load(object sender, EventArgs e)
        {
            discoConexionDB discoConex = new discoConexionDB();
            //listadisco = discoConex.listar();
            DGVDiscos.DataSource = discoConex.listar();
            //DGVDiscos.Columns["urlImagen"].Visible = false;
            //cargarImagen(listadisco[0].UrlImagenTapa);
        }

        //private void DGVDiscos_SelectionChanged(object sender, EventArgs e)
        //{
        //    Discos Seleccionado = (Discos)DGVDiscos.CurrentRow.DataBoundItem;
        //    cargarImagen(Seleccionado.UrlImagenTapa);
        //}
        //private void cargarImagen(string Imagen) 
        //{
        //try
        //{
        //    PBXTapa.Load(Imagen);
        //}
        //catch (Exception ex) 
        //{
        //    PBXTapa.Load("https://thumbs.dreamstime.com/b/ninguna-imagen-de-la-u%C3%B1a-del-pulgar-placeholder-para-los-foros-blogs-y-las-p%C3%A1ginas-web-148010362.jpg");            
        //}


    

        //}
    }
}
