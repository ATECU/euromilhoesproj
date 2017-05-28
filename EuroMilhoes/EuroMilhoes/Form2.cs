﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace EuroMilhoes
{
    public partial class Form2 : Form
    {
        private List<int> chli = new List<int>();
        private List<int> chliE = new List<int>();
        public Form2()
        {
            InitializeComponent();
            JogarBtn2.Enabled = false;

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

     

        private void SairBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void JogarBtn2_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            chli.Add(Convert.ToInt32(textBox1.Text));
            chli.Add(Convert.ToInt32(textBox2.Text));
            chli.Add(Convert.ToInt32(textBox3.Text));
            chli.Add(Convert.ToInt32(textBox4.Text));
            chli.Add(Convert.ToInt32(textBox5.Text));

            chliE.Add(Convert.ToInt32(textBox6.Text));
            chliE.Add(Convert.ToInt32(textBox7.Text));


            

            if (chli.Distinct().Count() != chli.Count() )
            {
                label1.Text = "fds ";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                chli.Clear();
                chliE.Clear();
               
            }
            else if (chliE.Distinct().Count() != chliE.Count())
            {
                    label1.Text = "fds  E";
                    textBox6.Clear();
                    textBox7.Clear();
                    chliE.Clear();
                    chli.Clear();
            }
            else
            {
                   // Chave ch = new Chave(chli);


                Chave chgen = new Chave();
                textBoxGen1.Text = chgen.getListaN()[0].ToString();
                textBoxGen2.Text = chgen.getListaN()[1].ToString();
                textBoxGen3.Text = chgen.getListaN()[2].ToString();
                textBoxGen4.Text = chgen.getListaN()[3].ToString();
                textBoxGen5.Text = chgen.getListaN()[4].ToString();

                textBoxEs1.Text = chgen.getListaE()[0].ToString();
                textBoxEs2.Text = chgen.getListaE()[1].ToString();
                chli.Clear();
                chliE.Clear();

            
                
            

               
            }
            

        }

        

        private void textIn(object sender, EventArgs e)
        {
            foreach (var textbox in this.Controls.OfType<TextBox>())
            {
                try
                {
                    if (Convert.ToInt32(textbox.Text) < 1 || Convert.ToInt32(textbox.Text) > 50)
                    {

                        textbox.Clear();

                      
                    }

                }
                catch (Exception o)
                {

                    textbox.Clear();
                }

                if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)
                        && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)
                        && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text)
                        && !String.IsNullOrEmpty(textBox7.Text))
                {
                    JogarBtn2.Enabled = true;
                }
                else
                {
                    JogarBtn2.Enabled = false;
                }
               
              
            }
        }

    

      
    }
}
