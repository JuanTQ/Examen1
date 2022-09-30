namespace Examen
{
    public partial class Form1 : Form
    {
        //public Double Monto=0;
       
        public Form1()
        {
            InitializeComponent();
            this.Monto = 0;
            this.USD = 0;
            this.MXN = 0;
            this.CAD = 0;
            this.EUR = 0;
            this.JPY = 0;
        }
        public Form1(string filtro,double Monto, double USD, double MXN, double CAD, double EUR, double JPY)
        {
            this.Monto = Monto;
            this.USD = USD;
            this.MXN = MXN;
            this.CAD = CAD;
            this.EUR = EUR;
            this.JPY = JPY;

        }
        public double Monto { get; set; }
        public double USD { get; set; }
        public double MXN { get; set; }
        public double CAD { get; set; }
        public double EUR { get; set; }
        public double JPY { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Visible = false;
            this.label1.Visible = false;
            this.textBox2.Visible = false;
            this.label2.Visible = false;
            this.textBox3.Visible = false;
            this.label3.Visible = false;
            this.textBox4.Visible = false;
            this.label4.Visible = false;
            this.textBox6.Visible = false;
            this.label5.Visible = false;
            this.Monto=Convert.ToInt32(textBox5.Text); 
            int indice= comboBox1.SelectedIndex;
            Form2 form2 = new Form2();
            form2.ShowDialog();
            switch (indice)
            {
                case 0:
                    this.MXN = 20.25;
                    this.CAD = 1.36;
                    this.EUR = 1.03;
                    this.JPY = 144.33;
                    break;
                case 1:
                    this.USD = 0.05;
                    this.MXN = 0;
                    this.CAD = 0.07;
                    this.EUR = 0.05;
                    this.JPY = 7.13;
                    break;
                case 2:
                    this.USD = 0.73;
                    this.MXN = 14.84;
                    this.EUR = 0.76;
                    this.JPY = 105.74;
                    break;
                case 3:
                    this.USD = 0.97;
                    this.MXN = 19.62;
                    this.CAD = 1.32;
                    this.JPY = 139.89;
                    break;
                case 4:
                    this.USD = 0.01;
                    this.MXN = 0.14;
                    this.CAD = 0.01;
                    this.EUR = 0.01;
                    break;

            }
            if ((form2.chk1 ==1)&&(indice!=0))
            {
                this.textBox1.Visible = true;
                this.label1.Visible = true;
                this.textBox1.Text = "$"+ Convert.ToString(Monto *USD);
                this.label1.Text = "USD - Dólar estadounidense";
            }
            if ((form2.chk2 == 2) && (indice != 1))
            {
                this.textBox2.Visible = true;
                this.label2.Visible = true;
                this.textBox2.Text = "$"+ Convert.ToString(Monto * MXN);
                this.label2.Text = "MXN - Peso mexicano";
            }
            if ((form2.chk3 == 3) && (indice != 2))
            {
                this.textBox3.Visible = true;
                this.label3.Visible = true;
                this.textBox3.Text = "$"+ Convert.ToString(Monto * CAD);
                this.label3.Text = "CAD - Dólar canadiense";
            }
            if ((form2.chk4 == 4) && (indice != 3))
            {
                this.textBox4.Visible = true;
                this.label4.Visible = true;
                this.textBox4.Text = "€"+ Convert.ToString(Monto * EUR);
                this.label4.Text = "EUR – Euro";
            }
            if ((form2.chk5 == 5) && (indice != 4))
            {
                this.textBox6.Visible = true;
                this.label5.Visible = true;
                this.textBox6.Text = "¥"+ Convert.ToString(Monto * JPY);
                this.label5.Text = "JPY - Yen japonés";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}