using System;
using System.Windows.Forms;

namespace Mcdonalds
{
    public partial class MenuInicio : Form
    {

        public delegate void EventoMostrarPuertasAbiertas();
        public EventoMostrarPuertasAbiertas MostrarPuertasAbiertas;

        public delegate void EventoMostrarNoticias();
        public EventoMostrarNoticias MostrarNoticias;

        public delegate void EventoMostrarNiños(Niños.MenuSeleccionado menu);
        public EventoMostrarNiños MostrarNiños;
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void BtnNoticias_Click(object sender, EventArgs e)
        {
            MostrarNoticias();
        }

        private void BtnCelebraciones_Click(object sender, EventArgs e)
        {
            MostrarNiños(Niños.MenuSeleccionado.Celebraciones);
        }

        private void BtnPuertasAbiertas_Click(object sender, EventArgs e)
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
