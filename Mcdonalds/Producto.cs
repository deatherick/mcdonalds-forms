using System.Windows.Forms;

namespace Mcdonalds
{
    public partial class Producto : Form
    {
        public Producto(System.Drawing.Image imagen, string titulo, string descripción)
        {
            InitializeComponent();
            pictureBox1.Image = imagen;
            lblTitulo.Text = titulo;
            lblContenido.Text = descripción;
        }
    }
}
