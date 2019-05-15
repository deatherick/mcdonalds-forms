using System;
using System.Windows.Forms;

namespace Mcdonalds
{
    public partial class Compañía : Form
    {
        public enum MenuSeleccionado
        {
            Compañía,
            Historia,
            McdiaFeliz,
            // ReSharper disable once InconsistentNaming
            RSE,
            HistoriaCajitaFeliz,
            ProgramaEscolar,
            Trabajar,
            Ética,
            Libro
        }
        public Compañía(MenuSeleccionado menu)
        {
            InitializeComponent();

            switch (menu)
            {
                case MenuSeleccionado.Compañía:
                    SeleccionarCompañía();
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
                case MenuSeleccionado.Ética:
                    SeleccionarÉtica();
                    break;
                case MenuSeleccionado.Libro:
                    SeleccionarLibro();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(menu), menu, null);
            }
        }

        public void SeleccionarCompañía()
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

        public void SeleccionarÉtica()
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

        private void HistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarHistoria();
        }

        private void CompañíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarCompañía();
        }

        private void LíneaDeÉticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarÉtica();
        }

        private void McDíaFelizPorLosNiñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarMcDiaFeliz();
        }

        private void RSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarRse();
        }

        private void HistoriaDeLaCajitaFelizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarHistoriaCajita();
        }

        private void ProgramaEscolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarProgramaEscolar();
        }

        private void TrabajarEnMcDonaldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarTrabajar();
        }

        private void Libro40AñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarLibro();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show(@"Se han enviado los datos, te contactaremos pronto");
            }
            else
            {
                MessageBox.Show(@"Favor llena todos los campos", @"McDonalds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KeyPressHandler(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
