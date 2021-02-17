using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = true;

            DialogResult dialogResult = MessageBox.Show("Doriti sa inchideti aceasta fereastra?", "Close", MessageBoxButtons.YesNo);
                
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void panel1_onClick(object sender, EventArgs e)
        {
            //Creez o instanta a formei pe care doresc sa o deschid
            Equation eq = new Equation();
            //Adaug un eveniment in urma caruia la deschirea formei eq, se va ascunde forma this
            eq.Shown += (o, args) => this.Hide();
            //Adaug un eveniment in urma caruia la inchiderea formei eq, se va deschide forma this
            eq.Closed += (o, args) => this.Show();
            //Afisez forma eq
            eq.Show();
            
        }

        private void panel2_onClick(object sender, EventArgs e)
        {
            PrimNumber pm = new PrimNumber();
            pm.Shown += (o, args) => this.Hide();
            pm.Closed += (o, args) => this.Show();
            pm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.panel1_onClick(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.panel1_onClick(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.panel2_onClick(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.panel2_onClick(sender, e);
        }
    }
}