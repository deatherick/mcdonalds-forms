using System;
using System.Windows.Forms;
using Mcdonalds.Properties;

namespace Mcdonalds
{
    public partial class Ubicaciones : Form
    {
        public Ubicaciones()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            GenerarImagenUbicación();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GenerarImagenUbicación();
        }

        private void GenerarImagenUbicación()
        {
            var imágenes = new[]
            {
                Resources.ubicacion1,
                Resources.ubicacion2,
                Resources.ubicacion3,
                Resources.ubicacion4,
                Resources.ubicacion5
            };
            var rnd = new Random();
            pictureBox1.Image = imágenes[rnd.Next(0, 4)];
        }

        private void Ubicaciones_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }
    }
}
