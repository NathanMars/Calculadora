namespace Proj02
{
    public partial class Form1 : Form
    {
        double aux = 0, acumulo=0;
        char op = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tbVisor.AppendText("1");
            //tbVisor.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tbVisor.AppendText("2");
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            tbVisor.AppendText("3");
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            tbVisor.AppendText("4");
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            tbVisor.AppendText("5");
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            tbVisor.AppendText("6");
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            tbVisor.AppendText("7");
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            tbVisor.AppendText("8");
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            tbVisor.AppendText("9");
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            tbVisor.AppendText("0");
        }

        private void btposneg_Click(object sender, EventArgs e)
        {
            if (tbVisor.Text != "")
            {
                if (Convert.ToDecimal(tbVisor.Text) > 0)
                    tbVisor.Text = "-" + tbVisor.Text;
                else
                    if (Convert.ToDecimal(tbVisor.Text) < 0)
                    tbVisor.Text = tbVisor.Text.Substring(1);
            }
            else
                tbVisor.Text = "-";
        }

        private void btponto_Click(object sender, EventArgs e)
        {
            if(tbVisor.Text != "")
              tbVisor.AppendText(".");
            else
              tbVisor.AppendText("0.");
        }

        private void btlimpa_Click(object sender, EventArgs e)
        {
            tbVisor.Clear();
            aux = 0;
            op = ' ';
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            AcumulaOperacao();
            tbVisor.Text = "" + aux;
            aux = 0;
            op = ' ';
        }

        private void btmais_Click(object sender, EventArgs e)
        {
            if(op==' ')
            {
                aux = Convert.ToDouble(tbVisor.Text);
                op = '+';
            }
            else
            {
                AcumulaOperacao();
                op = '+';
            }//fecha else
            tbVisor.Clear();
        }//fecha método do botão mais

        private void btmenos_Click(object sender, EventArgs e)
        {
            if (op == ' ')
            {
                aux = Convert.ToDouble(tbVisor.Text);
                op = '-';
            }
            else
            {
                AcumulaOperacao();
                op = '-';
            }//fecha else
            tbVisor.Clear();
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            if (op == ' ')
            {
                aux = Convert.ToDouble(tbVisor.Text);
                op = '/';
            }
            else
            {
                AcumulaOperacao();
                op = '/';
            }//fecha else
            tbVisor.Clear();
        }

        private void btmult_Click(object sender, EventArgs e)
        {
            if (op == ' ')
            {
                aux = Convert.ToDouble(tbVisor.Text);
                op = '*';
            }
            else
            {
                AcumulaOperacao();
                op = '*';
            }//fecha else
            tbVisor.Clear();
        }

        public void AcumulaOperacao()
        {
            if (op == '-')
            {
                aux -= Convert.ToDouble(tbVisor.Text);
            }
            if (op == '+')
            {
                aux += Convert.ToDouble(tbVisor.Text);
            }
            if (op == '/')
            {
                aux /= Convert.ToDouble(tbVisor.Text);
            }
            if (op == '*')
            {
                aux *= Convert.ToDouble(tbVisor.Text);
            }
        }
    }
}