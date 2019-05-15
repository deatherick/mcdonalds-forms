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
            menuInicio.MostrarNiños += MostrarNiños;
            menuInicio.MostrarPuertasAbiertas += MostrarPuertasAbiertas;
            panelContenedor.Controls.Add(menuInicio);
            menuInicio.FormBorderStyle = FormBorderStyle.None;
            menuInicio.Dock = DockStyle.Fill;
            menuInicio.Show();
        }

        public void MostrarCompañía()
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/compania/";
            var compañía = new Compañía(Compañía.MenuSeleccionado.Compañía)
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(compañía);
            compañía.FormBorderStyle = FormBorderStyle.None;
            compañía.Dock = DockStyle.Fill;
            compañía.Show();
        }

        public void MostrarNiños(Niños.MenuSeleccionado menu)
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/ninos/";
            var compañía = new Niños(menu)
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(compañía);
            compañía.FormBorderStyle = FormBorderStyle.None;
            compañía.Dock = DockStyle.Fill;
            compañía.Show();
        }

        public void MostrarLineaÉtica()
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/compania/";
            var compañía = new Compañía(Compañía.MenuSeleccionado.Ética)
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(compañía);
            compañía.FormBorderStyle = FormBorderStyle.None;
            compañía.Dock = DockStyle.Fill;
            compañía.Show();
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

        public void MostrarContáctenos()
        {
            panelContenedor.Controls.Clear();
            txtUrl.Text = @"https://mcdonalds.com.gt/contactenos/";
            var contáctenos = new Contáctenos()
            {
                TopLevel = false
            };
            panelContenedor.Controls.Add(contáctenos);
            contáctenos.FormBorderStyle = FormBorderStyle.None;
            contáctenos.Dock = DockStyle.Fill;
            contáctenos.Show();
        }

        public void MostrarUbicación()
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

        private void PictureBox1_Click(object sender, System.EventArgs e)
        {
            MostrarInicio();
        }

        private void CompañíaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarCompañía();
        }

        private void LíneaDeÉticaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarLineaÉtica();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void DesayunosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.Desayuno);
        }

        private void AlmuerzosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.Almuerzo);
        }

        private void CajitaFelizToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.CajitaFeliz);
        }

        private void PostresToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.Postres);
        }

        private void EnsaladasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.Ensaladas);
        }

        private void BebidasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.Bebidas);
        }

        private void InformaciónNutricionalToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNuestroMenu(NuestroMenu.NuestroMenuSeleccionado.InformaciónNutricional);
        }

        private void NiñosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarNiños(Niños.MenuSeleccionado.Celebraciones);
        }

        private void ContáctenosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarContáctenos();
        }

        private void UbicacionesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MostrarUbicación();
        }
    
    }
}
