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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void numIn(object sender, EventArgs e)
        {
            foreach (var textbox in this.Controls.OfType<TextBox>())
            {
                try
                {

                    if (Convert.ToInt32(textbox.Text) < 1  || Convert.ToInt32(textbox.Text) > 50)
                    {
                        textbox.Clear();
                        
                    }



                }catch(Exception f)
                {
                    textbox.Clear();

                }




            }
        }

        private void SairBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
