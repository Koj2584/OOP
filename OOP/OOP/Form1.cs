using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Osoba prvni = new Osoba(textBox1.Text, maskedTextBox1.Text);
            Osoba druha = new Osoba(textBox3.Text, maskedTextBox2.Text);

            MessageBox.Show(prvni.ToString());
            MessageBox.Show(druha.ToString());
            druha.NastavJmeno("Franta");
            MessageBox.Show("Změna jména na " + druha.VypisJmeno());
            MessageBox.Show(prvni.Starsi(druha));
        }
    }
}
