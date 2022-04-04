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
            string textSave = "";
            string hurufPertama = "";
            string hurufKedua = "";
            int indexArray = 0;
            int indexArray2 = 0;
            int selisih = 0;
            char[] arrayHuruf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            textSave = tBoxKalimat.Text.ToUpper();
            hurufPertama = tBoxHuruf.Text.ToUpper();
            hurufKedua = tBoxMenjadi.Text.ToUpper();
           textSave.ToCharArray();
            hurufPertama.ToCharArray();
            hurufKedua.ToCharArray();
            for (int i = 0; i < arrayHuruf.Length; i++)
            {
                if (hurufPertama == arrayHuruf[i].ToString())
                    indexArray = i;
            }
            for (int j = 0; j < arrayHuruf.Length; j++)
            {
                if (hurufKedua == arrayHuruf[j].ToString())
                    indexArray2 = j;
            }
            if (indexArray + selisih < 0)
            {
                selisih = indexArray + selisih;
                selisih = 26 + selisih;
               // selisih = selisih * -1;
            }

            else 
            {
                selisih = indexArray + selisih;
                if (selisih >= 26)
                {
                    selisih = selisih - 26;
                }
               
             }
            lblOutput.Text = tBoxKalimat.Text.ToUpper();
            /*var index = 0;

            char[] Huruf = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int simpanindex = 0;

            string boxHuruf = tBoxHuruf.Text;
            char[] arrayBoxHuruf = boxHuruf.ToCharArray();

            string boxMenjadi = tBoxMenjadi.Text;
            char[] arrayBoxMenjadi = boxMenjadi.ToCharArray();

            for (int i = 0; i < Huruf.Length; i++)
            {
                if(Huruf[i] == tBoxKalimat.Text[0])
                {
                    simpanindex = i;
                }
               
                int selisih = boxMenjadi - boxHuruf;
                
            } */
            
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void lblHasil_Click(object sender, EventArgs e)
        {
           
        }
    }
}