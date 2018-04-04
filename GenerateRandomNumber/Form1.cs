using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateRandomNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 3;
            b = 628;
            int result;
            Random rndNumber = new Random();
            result = rndNumber.Next(a,b);
            labelResult.Text = result.ToString();
            labelResult.BackColor = Color.White;
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelResult.BackColor = Color.Red;
        }

        private void buttonGenerate_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
