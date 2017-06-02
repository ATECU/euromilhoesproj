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
            lbl1.Text = " " + premio[0].ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
