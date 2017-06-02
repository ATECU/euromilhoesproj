using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EuroMilhoes
{
    public partial class Form3 : Form
    {
        private List<string> premio = new List<string>();
       
        public Form3(List<string> a)
        {
            InitializeComponent();
            this.premio = a;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          ((Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2) + 230);
            /*li.Add(numero);
            li.Add(estrelas);
            li.Add(num.Count.ToString());
            li.Add(es.Count.ToString());
            li.Add(premio);*/
            string num = " Numero";
            string estrela = " Estrela";
            if (Convert.ToInt32( premio[2]) > 1)
            {
                 num += "s";
            }
            else if (premio[2] == "0")
            {
                num += "s";
            }
            
            

            if (Convert.ToInt32(premio[3]) > 1)
            {
                estrela += "s";
            }
            else if (premio[3] == "0")
            {
                estrela += "s";
            }
            


            if (premio[4] == "3" || premio[4] == "7" || premio[4] == "10" || premio[4] == "13")
            {
                pictureBox1.Hide();
            }

            if (premio[4] == "0a")
            {
                lbl4.Text = "NÃO GANHOU NENHUM PRÉMIO";
                lbl1.Text = " " + premio[2] +  num + " + " + premio[3] + estrela;
                lbl2.Text = " " + premio[0];
                pictureBox1.Hide();

            }
            else if (premio[4] == "0b")
            {

                lbl4.Text = "NÃO GANHOU NENHUM PRÉMIO";
                lbl1.Text = " " + premio[2] + num + " + " + premio[3] + estrela;
                lbl2.Text = " " + premio[0];
                lbl3.Text = " " + premio[1];
               

            }
            else if (premio[4] == "0c")
            {
                lbl4.Text = "NÃO GANHOU NENHUM PRÉMIO";
                lbl1.Text = " " + premio[2] + num + " + " + premio[3] + estrela;
                lbl2.Text = " " + premio[0];
                lbl3.Text = " " + premio[1];
                
            }
            else if (premio[4] == "0d")
            {
                lbl4.Text = "NÃO GANHOU NENHUM PRÉMIO";
                lbl1.Text = " " + premio[2] + num + " + " + premio[3] + estrela;
                lbl3.Text = " " + premio[1];
            }
            else if (premio[4] == "0")
            {
                pictureBox1.Hide();
                lbl4.Text = "NÃO GANHOU NENHUM PRÉMIO";
                lbl1.Text = " " + premio[2] + num + " + " + premio[3] + estrela;
            }
            else
            {
                lbl5.Text = "GANHOU O " + premio[4] + "º PRÉMIO !";
                lbl1.Text = " " + premio[2] + num + " + " + premio[3] + estrela;
                lbl2.Text = " " + premio[0];
                lbl3.Text = " " + premio[1];
            }





        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
