using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace praktikumW7
{
    public partial class FormQuizPanda : Form
    {
        public FormQuizPanda()
        {
            InitializeComponent();
        }

        private void FormQuizPanda_Load(object sender, EventArgs e)
        {

        }

        private void tBoxKalimat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxHuruf_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxMenjadi_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnKonversi_Click(object sender, EventArgs e)
        {
            var index = 0;
            char[] Huruf = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int simpanindex = 0;
            for (int j = 0; j < Huruf.Length; j++)
            {
                if(Huruf[j] == tBoxKalimat.Text[0])
                {
                    simpanindex = j;
                }
                char hurufku1 = tBoxHuruf.Text;
                char hurufku2 = tBoxMenjadi.Text;
                int selisih = hurufku2 - hurufku1;
                MessageBox.Show(selisih.ToString());
            }
            //lblOutput = Array.IndexOf(Huruf, value);
            lblOutput.Text = tBoxKalimat.Text;
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void lblHasil_Click(object sender, EventArgs e)
        {
           
        }
    }
}