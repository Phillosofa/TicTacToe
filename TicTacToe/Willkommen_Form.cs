using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Willkommen_Form : Form
    {
        public Willkommen_Form()
        {
            InitializeComponent();
        }

        private void btn_1spieler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Modus in Arbeit");
        }

        private void btn_2spieler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Spielfeld sForm = new Spielfeld();
            sForm.ShowDialog();
            Application.Exit();
        }
    }
}
