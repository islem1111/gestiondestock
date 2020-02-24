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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            pnlParam.Visible = false;
        }

        //private void button1_Click(object sender, EventArgs e)
       // {
            //Application.Exit();
        //}

       // private void button2_Click(object sender, EventArgs e)
        //{
           // this.WindowState = FormWindowState.Minimized;
        //}

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pabtn.Top = btnPF.Top;
            pabtn.Top = btnUt.Top;
            if (!panlafficher.Controls.Contains(Form1.Instance))
            {
                panlafficher.Controls.Add(Form1.Instance);
                Form1.Instance.Dock = DockStyle.Fill;
                Form1.Instance.BringToFront();
            }
            else
            { Form1.Instance.BringToFront(); }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pabtn.Top = btnPR.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pabtn.Top = btnLi.Top;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pabtn.Top = btnMa.Top;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            pabtn.Top = btnMP.Top;
        }

        private void btnOU_Click(object sender, EventArgs e)
        {
            pabtn.Top = btnOU.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pabtn.Top = btnUt.Top;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            pnlParam.Size = new Size(272, 137);
            pnlParam.Visible = !pnlParam.Visible;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlParam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
