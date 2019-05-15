using System;
using System.Windows.Forms;
using Mcdonalds.Properties;

namespace Mcdonalds
{
    public partial class MenuInicio : Form
    {

        public delegate void EventoMostrarPuertasAbiertas();
        public EventoMostrarPuertasAbiertas MostrarPuertasAbiertas;

        public delegate void EventoMostrarNoticias();
        public EventoMostrarNoticias MostrarNoticias;

        public delegate void EventoMostrarNinos(Ninos.MenuSeleccionado menu);
        public EventoMostrarNinos MostrarNinos;
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void btnNoticias_Click(object sender, EventArgs e)
        {
            MostrarNoticias();
        }

        private void btnCelebraciones_Click(object sender, EventArgs e)
        {
            MostrarNinos(Ninos.MenuSeleccionado.Celebraciones);
        }

        private void btnPuertasAbiertas_Click(object sender, EventArgs e)
        {
            MostrarPuertasAbiertas();
        }

        private void MenuInicio_Load(object sender, EventArgs e)
        {
            var myTimer = new Timer
            {
                Interval = 3 * 1000
            };
            // 3 segundos
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex + 1 < tabControl1.TabCount) ?
                tabControl1.SelectedIndex + 1 : 0;
        }
    }
}
