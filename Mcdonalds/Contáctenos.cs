using System;
using System.Windows.Forms;

namespace Mcdonalds
{
    public partial class Contáctenos : Form
    {
        public Contáctenos()
        {
            InitializeComponent();
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
