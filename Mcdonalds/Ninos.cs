﻿using System;
using System.Windows.Forms;

namespace Mcdonalds
{
    public partial class Ninos : Form
    {
        public enum MenuSeleccionado
        {
            Celebraciones,
            Ronald,
            Juegos,
            Calendario,
            Refacciones,
            ClubRonald
        }
        public Ninos(MenuSeleccionado menu)
        {
            InitializeComponent();

            switch (menu)
            {
                case MenuSeleccionado.Celebraciones:
                    SeleccionarCelebraciones();
                    break;
                case MenuSeleccionado.Ronald:
                    SeleccionarRonald();
                    break;
                case MenuSeleccionado.Juegos:
                    SeleccionarJuegos();
                    break;
                case MenuSeleccionado.Calendario:
                    SeleccionarCalendario();
                    break;
                case MenuSeleccionado.Refacciones:
                    SeleccionarRefacciones();
                    break;
                case MenuSeleccionado.ClubRonald:
                    SeleccionarClubRonald();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("menu", menu, null);
            }
        }

        public void SeleccionarCelebraciones()
        {           
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            celebracionesToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlNinos.SelectedTab = tabCelebraciones;
        }

        public void SeleccionarRonald()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            ronaldMcdonaldToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlNinos.SelectedTab = tabRonald;
        }

        public void SeleccionarJuegos()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            juegosToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlNinos.SelectedTab = tabJuegos;
        }

        public void SeleccionarCalendario()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            calendarioDecoracionToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlNinos.SelectedTab = tabCalendario;
        }

        public void SeleccionarRefacciones()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            refaccionesSantaToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlNinos.SelectedTab = tabRefacciones;
        }

        public void SeleccionarClubRonald()
        {
            foreach (ToolStripItem items in menuLateral.Items)
            {
                items.BackgroundImage = null;
            }
            clubRonaldToolStripMenuItem.BackgroundImage = Properties.Resources.vtabs_hover;
            tabControlNinos.SelectedTab = tabClubRonald;
        }

        private void historiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarRonald();
        }

        private void companiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarCelebraciones();
        }

        private void mcDíaFelizPorLosNiñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarJuegos();
        }

        private void rSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarCalendario();
        }

        private void historiaDeLaCajitaFelizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarRefacciones();
        }

        private void programaEscolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeleccionarClubRonald();
        }
    }
}
