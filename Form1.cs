using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeyBlockingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                MessageBox.Show("Клавиша заблокирована.");
            }

            if (e.KeyCode == Keys.E)
            {
                Application.Exit();
            }
        }
    }
}
