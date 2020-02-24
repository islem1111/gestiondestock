using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static Form1 CC;
        //creer une instance pour le controle
        public static Form1 Instance
        { get
            {
                if(CC==null)
                {
                    CC = new Form1();
                }
                return CC;
            }
        }


 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtrecherche.Text=="Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
               
            }
        }
    }
}
