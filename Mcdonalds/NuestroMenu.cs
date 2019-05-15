using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Mcdonalds.Properties;

namespace Mcdonalds
{
    public partial class NuestroMenu : Form
    {
        public enum NuestroMenuSeleccionado
        {
            Desayuno,
            Almuerzo,
            CajitaFeliz,
            Postres,
            Ensaladas,
            Bebidas,
            InformaciónNutricional
        }
        public NuestroMenu(NuestroMenuSeleccionado menu)
        {
            InitializeComponent();
            switch (menu)
            {
                case NuestroMenuSeleccionado.Desayuno:
                    MostrarDesayuno();
                    break;
                case NuestroMenuSeleccionado.Almuerzo:
                    MostrarAlmuerzo();
                    break;
                case NuestroMenuSeleccionado.CajitaFeliz:
                    MostrarCajita();
                    break;
                case NuestroMenuSeleccionado.Postres:
                    MostrarPostres();
                    break;
                case NuestroMenuSeleccionado.Ensaladas:
                    MostrarEnsaladas();
                    break;
                case NuestroMenuSeleccionado.Bebidas:
                    MostrarBebidas();
                    break;
                case NuestroMenuSeleccionado.InformaciónNutricional:
                    MostrarInformaciónNutricional();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(menu), menu, null);
            }
        }

        private void MostrarDesayuno()
        {
            pictureBox1.Image = Resources.desayunos_960x290_copy_copy;
            foreach (ToolStripItem items in menuStrip1.Items)
            {
                items.BackColor = SystemColors.Control;
                items.ForeColor = SystemColors.ControlText;
            }
            desayunosToolStripMenuItem.BackColor = Color.Crimson;
            desayunosToolStripMenuItem.ForeColor = Color.White;
            tabControl1.SelectedTab = tabDesayuno;
        }

        private void MostrarAlmuerzo()
        {
            pictureBox1.Image = Resources.almuerzo_cena;
            foreach (ToolStripItem items in menuStrip1.Items)
            {
                items.BackColor = SystemColors.Control;
                items.ForeColor = SystemColors.ControlText;
            }
            almuerzoCenaToolStripMenuItem.BackColor = Color.Crimson;
            almuerzoCenaToolStripMenuItem.ForeColor = Color.White;
            tabControl1.SelectedTab = tabAlmuerzo;
        }

        private void MostrarCajita()
        {
            pictureBox1.Image = Resources._960x290Cajita;
            foreach (ToolStripItem items in menuStrip1.Items)
            {
                items.BackColor = SystemColors.Control;
                items.ForeColor = SystemColors.ControlText;
            }
            cajitaFelizToolStripMenuItem.BackColor = Color.Crimson;
            cajitaFelizToolStripMenuItem.ForeColor = Color.White;
            tabControl1.SelectedTab = tabCajitaFeliz;
        }

        private void MostrarPostres()
        {
            pictureBox1.Image = Resources.Postres_960x290;
            foreach (ToolStripItem items in menuStrip1.Items)
            {
                items.BackColor = SystemColors.Control;
                items.ForeColor = SystemColors.ControlText;
            }
            postresToolStripMenuItem.BackColor = Color.Crimson;
            postresToolStripMenuItem.ForeColor = Color.White;
            tabControl1.SelectedTab = tabPostres;
        }

        private void MostrarEnsaladas()
        {
            pictureBox1.Image = Resources.ensaladas1;
            foreach (ToolStripItem items in menuStrip1.Items)
            {
                items.BackColor = SystemColors.Control;
                items.ForeColor = SystemColors.ControlText;
            }
            ensaladasToolStripMenuItem.BackColor = Color.Crimson;
            ensaladasToolStripMenuItem.ForeColor = Color.White;
            tabControl1.SelectedTab = tabEnsaladas;
        }

        private void MostrarBebidas()
        {
            pictureBox1.Image = Resources.header_bebidas;
            foreach (ToolStripItem items in menuStrip1.Items)
            {
                items.BackColor = SystemColors.Control;
                items.ForeColor = SystemColors.ControlText;
            }
            bebidasToolStripMenuItem.BackColor = Color.Crimson;
            bebidasToolStripMenuItem.ForeColor = Color.White;
            tabControl1.SelectedTab = tabBebidas;
        }

        private static void MostrarInformaciónNutricional()
        {
            Image imagen = Resources.tabla_nutricional_mc;
            const string titulo = "Información Nutricional";
            const string descripción = "Si quieres saber los contenidos nutricionales de nuestros productos, descarga la tabla nutricional haciendo click en el botón de abajo.";
            var productoDetalle = new Producto(imagen, titulo, descripción);
            productoDetalle.ShowDialog();
        }

        private static void PanelProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Panel panel;
                if (typeof(PictureBox) == sender.GetType())
                {
                    var picture = (PictureBox) sender;
                    panel = (Panel)picture.Parent;
                }
                else if (typeof(Label) == sender.GetType())
                {
                    var label = (Label) sender;
                    panel = (Panel) label.Parent;
                }
                else
                {
                    panel = (Panel)sender;
                }
             
                Image imagen = null;
                string titulo = null;
                string descripción = null;
                foreach (var pb in panel.Controls.OfType<PictureBox>())
                {
                    imagen = pb.Image;
                    descripción = pb.Tag.ToString();
                }
                foreach (var lbl in panel.Controls.OfType<Label>())
                {
                    titulo = lbl.Text;
                }
                var productoDetalle = new Producto(imagen, titulo, descripción);
                productoDetalle.ShowDialog();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

        }

        private void NuestroMenu_Load(object sender, EventArgs e)
        {
            foreach (var tabPage in tabControl1.Controls.OfType<TabPage>())
            {
                foreach (var panel in tabPage.Controls.OfType<Panel>())
                {
                    foreach (var picture in panel.Controls.OfType<PictureBox>())
                    {
                        picture.Click += PanelProducto_Click;
                    }
                    foreach (var label in panel.Controls.OfType<Label>())
                    {
                        label.Click += PanelProducto_Click;
                    }
                    panel.Click += PanelProducto_Click;
                }
            }
            
        }

        private void DesayunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarDesayuno();
        }

        private void AlmuerzoCenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarAlmuerzo();
        }

        private void CajitaFelizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarCajita();
        }

        private void PostresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPostres();
        }

        private void EnsaladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarEnsaladas();
        }

        private void BebidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarBebidas();
        }

        private void InformaciónNutricionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarInformaciónNutricional();
        }

    }
}
