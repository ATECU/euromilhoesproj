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
using System.IO;

namespace EuroMilhoes
{
    public partial class Form2 : Form
    {
        private List<int> chli = new List<int>();
        private List<int> chliE = new List<int>();
        private List<string> stList = new List<string>();
     
        public Form2()
        {
            InitializeComponent();
          


        }



        private void SairBtn2_Click(object sender, EventArgs e)
        {


            new Form1().Show();
            this.Hide();
        }


        private void JogarBtn2_Click(object sender, EventArgs e)
        {


            if (valNUm())
            {
                Chave chgen = new Chave();
                Chave ch = new Chave(chli,chliE);
                textBoxGen1.Text = chgen.getListaN()[0].ToString();
                textBoxGen2.Text = chgen.getListaN()[1].ToString();
                textBoxGen3.Text = chgen.getListaN()[2].ToString();
                textBoxGen4.Text = chgen.getListaN()[3].ToString();
                textBoxGen5.Text = chgen.getListaN()[4].ToString();

                textBoxEs1.Text = chgen.getListaE()[0].ToString();
                textBoxEs2.Text = chgen.getListaE()[1].ToString();
                Form3 frm = new Form3(ch.premio(ch.compareNum(chgen), ch.compareEs(chgen)));
                frm.Show();
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


        private void textInEs(object sender, EventArgs e)
        {

            try
            {

                if (Convert.ToInt32(textBox6.Text) < 1 || Convert.ToInt32(textBox6.Text) > 12)
                {

                    textBox6.Clear();


                }


            }
            catch (Exception o)
            {
                textBox6.Clear();
                
            }
            try
            {

                if (Convert.ToInt32(textBox7.Text) < 1 || Convert.ToInt32(textBox7.Text) > 12)
                {
                    textBox7.Clear();
                }
            }
            catch(Exception o)
            {
                textBox7.Clear();
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

        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            JogarBtn2.Enabled = false;
            lerFich();
            comboBox1.DataSource = stList;
            comboBox1.SelectedIndex = -1;

            JogarBtn2.Enabled = false;
            this.MaximizeBox = false;
            if (!File.Exists(@"numList.txt"))
            {
                File.Create(@"numList.txt");
            }

        }


        private void lerFich()
        {
            if (File.Exists("numList.txt"))
                {
                StreamReader rd = new StreamReader(@"numList.txt");
                while (!rd.EndOfStream)
                {
                    stList.Add(rd.ReadLine());


                }

                rd.Close();
           }
        }

        private void escrevFich(string nums)
        {

            StreamWriter wr = new StreamWriter(@"numList.txt", true);
            wr.WriteLine(nums);

            wr.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] palavras;
            
            if (comboBox1.Text != "")
            {
                palavras = stList[comboBox1.SelectedIndex].Split('|');
                textBox1.Text = palavras[0];
                textBox2.Text = palavras[1];
                textBox3.Text = palavras[2];
                textBox4.Text = palavras[3];
                textBox5.Text = palavras[4];
                textBox6.Text = palavras[5];
                textBox7.Text = palavras[6];
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
           

        }


        public void refreshList(List<string> list)
        {
           
            comboBox1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = 0;
            bool veri; 
            if (valNUm()) {

                Chave ch = new Chave(chli, chliE);
                veri = verFich();
                if (veri)
                {
                    escrevFich(ch.toFich());

                }
                index = comboBox1.SelectedIndex;
                
                stList = null;
                stList = new List<string>();
                lerFich();
                refreshList(stList);
                if (veri) {
                    comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                }
                else
                {
                    comboBox1.SelectedIndex = index;
                }
                chli.Clear();
                chliE.Clear();
                

            }


        }
        private bool verFich()
        {


            int x = 0;
            Chave ch = new Chave(chli, chliE);
            foreach (string li in File.ReadLines(@"numList.txt") )
            {
                if (li.Contains(ch.toFich()))
                {

                    return false;
                }
                x++;
            }


            return true;
        }


        private bool valNUm()
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)
                         && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)
                         && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text)
                         && !String.IsNullOrEmpty(textBox7.Text))
            {

                chli.Add(Convert.ToInt32(textBox1.Text));
                chli.Add(Convert.ToInt32(textBox2.Text));
                chli.Add(Convert.ToInt32(textBox3.Text));
                chli.Add(Convert.ToInt32(textBox4.Text));
                chli.Add(Convert.ToInt32(textBox5.Text));

                chliE.Add(Convert.ToInt32(textBox6.Text));
                chliE.Add(Convert.ToInt32(textBox7.Text));


                if (chli.Distinct().Count() != chli.Count())
                {
                    MessageBox.Show("Não inserir numeros repetidos");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    chli.Clear();
                    if (chliE.Distinct().Count() != chliE.Count())
                    {
                        MessageBox.Show("Não inserir estrelas repetidas");
                        textBox6.Clear();
                        textBox7.Clear();
                        chliE.Clear();
                        chli.Clear();
                    }
                    chliE.Clear();


                }
                else if (chliE.Distinct().Count() != chliE.Count())
                {
                    MessageBox.Show("Não inserir estrelas repetidas");
                    textBox6.Clear();
                    textBox7.Clear();
                    chliE.Clear();
                    chli.Clear();
                }
                else
                {

                    chli.Sort();
                    chliE.Sort();



                    textBox1.Text = chli[0].ToString();
                    textBox2.Text = chli[1].ToString();
                    textBox3.Text = chli[2].ToString();
                    textBox4.Text = chli[3].ToString();
                    textBox5.Text = chli[4].ToString();
                    textBox6.Text = chliE[0].ToString();
                    textBox7.Text = chliE[1].ToString();
                    return true;
                }
               
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                Chave chgen = new Chave();

                textBox1.Text = chgen.getListaN()[0].ToString();
                textBox2.Text = chgen.getListaN()[1].ToString();
                textBox3.Text = chgen.getListaN()[2].ToString();
                textBox4.Text = chgen.getListaN()[3].ToString();
                textBox5.Text = chgen.getListaN()[4].ToString();

                textBox6.Text = chgen.getListaE()[0].ToString();
                textBox7.Text = chgen.getListaE()[1].ToString();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            textBoxGen1.Text = "";
            textBoxGen2.Text = "";
            textBoxGen3.Text = "";
            textBoxGen4.Text = "";
            textBoxGen5.Text = "";
            textBoxEs1.Text = "";
            textBoxEs2.Text = "";
        }
    }  

            
}
