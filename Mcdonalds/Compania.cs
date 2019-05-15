using System;
using System.Windows.Forms;

namespace Mcdonalds
{
    public partial class Compania : Form
    {
        public enum MenuSeleccionado
        {
            Compania,
            Historia,
            McdiaFeliz,
            RSE,
            HistoriaCajitaFeliz,
            ProgramaEscolar,
            Trabajar,
            Etica,
            Libro
        }
        public Compania(MenuSeleccionado menu)
        {
            InitializeComponent();

            switch (menu)
            {
                case MenuSeleccionado.Compania:
                    SeleccionarCompania();
                    break;
                case MenuSeleccionado.Historia:
                    SeleccionarHistoria();
                    break;
                case MenuSeleccionado.McdiaFeliz:
                    SeleccionarMcDiaFeliz();
                    break;
                case MenuSeleccionado.RSE:
                    SeleccionarRse();
                    break;
                case MenuSeleccionado.HistoriaCajitaFeliz:
                    SeleccionarHistoriaCajita();
                    break;
                case MenuSeleccionado.ProgramaEscolar:
                    SeleccionarProgramaEscolar();
                    break;
                case MenuSeleccionado.Trabajar:
                    SeleccionarTrabajar();
                    break;
                case MenuSeleccionado.Etica:
                    SeleccionarEtica();
                    break;
                case MenuSeleccionado.Libro:
                    SeleccionarLibro();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("menu", menu, null);
            }
        }

        public void SeleccionarCompania()
        {           
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            companiaToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlCompania.SelectedTab = tabCompania;
        }

        public void SeleccionarHistoria()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            historiaToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlCompania.SelectedTab = tabHistoria;
        }

        public void SeleccionarMcDiaFeliz()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            mcDíaFelizPorLosNiñosToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlCompania.SelectedTab = tabMcdiaFeliz;
        }

        public void SeleccionarRse()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            rSEToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlCompania.SelectedTab = tabRse;
        }

        public void SeleccionarHistoriaCajita()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            historiaDeLaCajitaFelizToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlCompania.SelectedTab = tabHistoriaCajita;
        }

        public void SeleccionarProgramaEscolar()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            programaEscolarToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlCompania.SelectedTab = tabProgramaEscolar;
        }

        public void SeleccionarTrabajar()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            trabajarEnMcDonaldsToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlCompania.SelectedTab = tabTrabajar;
        }

        public void SeleccionarEtica()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            líneaDeÉticaToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlCompania.SelectedTab = tabLineaEtica;
        }

        public void SeleccionarLibro()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            libro40AñosToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlCompania.SelectedTab = tabLibro;
        }

        private void historiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarHistoria();
        }

        private void companiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarCompania();
        }

        private void líneaDeÉticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarEtica();
        }

        private void mcDíaFelizPorLosNiñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarMcDiaFeliz();
        }

        private void rSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarRse();
        }

        private void historiaDeLaCajitaFelizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarHistoriaCajita();
        }

        private void programaEscolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarProgramaEscolar();
        }

        private void trabajarEnMcDonaldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarTrabajar();
        }

        private void libro40AñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarLibro();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show(@"Se han enviado los datos, te contactaremos pronto");
            }
            else
            {
                MessageBox.Show(@"Favor llena todos los campos", "McDonalds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
