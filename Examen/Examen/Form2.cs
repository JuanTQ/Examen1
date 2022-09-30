using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.chk1 = 0;
            this.chk2 = 0;
            this.chk3 = 0;
            this.chk4 = 0;
            this.chk5 = 0;

        }
        public Form2(double Monto)
        {
            this.chk1 = chk1;
            this.chk2 = chk1;
            this.chk3 = chk1;
            this.chk4 = chk1;
            this.chk5 = chk1;

        }
        public double chk1 { get; set; }
        public double chk2 { get; set; }
        public double chk3 { get; set; }
        public double chk4 { get; set; }
        public double chk5 { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (checkBox1.Checked == true)
            {
                this.chk1 = 1;
                this.Close();
            }
            if (checkBox2.Checked == true)
            {
                this.chk2 = 2;
                this.Close();
            }
            if (checkBox3.Checked == true)
            {
                this.chk3 = 3;
                this.Close();
            }
            if (checkBox4.Checked == true)
            {
                this.chk4 = 4;
                this.Close();
            }
            if (checkBox5.Checked == true)
            {
                this.chk5 = 5;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
