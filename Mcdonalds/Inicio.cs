using System.Windows.Forms;

namespace Mcdonalds
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            MostrarInicio();
        }

        public void MostrarInicio()
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt";
            var menuInicio = new MenuInicio()
            {
                TopLevel = false
            };
            menuInicio.MostrarNoticias += MostrarNoticias;
            menuInicio.MostrarNinos += MostrarNinos;
            menuInicio.MostrarPuertasAbiertas += MostrarPuertasAbiertas;
            panelContenedor.Controls.Add(menuInicio);
            menuInicio.FormBorderStyle = FormBorderStyle.None;
            menuInicio.Dock = DockStyle.Fill;
            menuInicio.Show();
        }

        public void MostrarCompania()
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/compania/";
            var compania = new Compania(Compania.MenuSeleccionado.Compania)
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(compania);
            compania.FormBorderStyle = FormBorderStyle.None;
            compania.Dock = DockStyle.Fill;
            compania.Show();
        }

        public void MostrarNinos(Ninos.MenuSeleccionado menu)
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/ninos/";
            var compania = new Ninos(menu)
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(compania);
            compania.FormBorderStyle = FormBorderStyle.None;
            compania.Dock = DockStyle.Fill;
            compania.Show();
        }

        public void MostrarLineaEtica()
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/compania/";
            var compania = new Compania(Compania.MenuSeleccionado.Etica)
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(compania);
            compania.FormBorderStyle = FormBorderStyle.None;
            compania.Dock = DockStyle.Fill;
            compania.Show();
        }

        public void MostrarNoticias()
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/noticias/";
            var noticias = new Noticias()
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(noticias);
            noticias.FormBorderStyle = FormBorderStyle.None;
            noticias.Dock = DockStyle.Fill;
            noticias.Show();
        }

        public void MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado menu)
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/nuestro-menu/";
            var nuestroMenu = new NuestroMenu(menu)
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(nuestroMenu);
            nuestroMenu.FormBorderStyle = FormBorderStyle.None;
            nuestroMenu.Dock = DockStyle.Fill;
            nuestroMenu.Show();
        }

        public void MostrarContactenos()
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/contactenos/";
            var contactenos = new Contactenos()
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(contactenos);
            contactenos.FormBorderStyle = FormBorderStyle.None;
            contactenos.Dock = DockStyle.Fill;
            contactenos.Show();
        }

        public void MostrarUbicacion()
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/ubicaciones-mc/";
            var ubicaciones = new Ubicaciones()
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(ubicaciones);
            ubicaciones.FormBorderStyle = FormBorderStyle.None;
            ubicaciones.Dock = DockStyle.Fill;
            ubicaciones.Show();
        }

        public void MostrarPuertasAbiertas()
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/puertas-abiertas-2/";
            var puertasAbiertas = new PuertasAbiertas()
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(puertasAbiertas);
            puertasAbiertas.FormBorderStyle = FormBorderStyle.None;
            puertasAbiertas.Dock = DockStyle.Fill;
            puertasAbiertas.Show();
        }

        private void nuestroMenuToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            MostrarInicio();
        }

        private void compañiaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarCompania();
        }

        private void líneaDeEticaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarLineaEtica();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void desayunosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.Desayuno);
        }

        private void almuerzosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.Almuerzo);
        }

        private void cajitaFelizToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.CajitaFeliz);
        }

        private void postresToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.Postres);
        }

        private void ensaladasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.Ensaladas);
        }

        private void bebidasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.Bebidas);
        }

        private void informacionNutricionalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.InformacionNutricional);
        }

        private void niñosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNinos(Ninos.MenuSeleccionado.Celebraciones);
        }

        private void cONTÁCTENOSToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarContactenos();
        }

        private void ubicacionesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarUbicacion();
        }
    
    }
}
