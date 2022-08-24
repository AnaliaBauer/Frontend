namespace Calculadora1
{
    public partial class frmInicio : Form
    {


        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(txtNum1.Text); 
            decimal num2 = Convert.ToDecimal(txtNum2.Text);
            if (txtOperando.Text == "+")
            {
                decimal suma = numero1 + num2;
                lblResultado.Text = suma.ToString();
                lblResultado.Visible = true;
            }

            else if (txtOperando.Text == "-")
            {
                decimal resta = numero1 - num2;
                lblResultado.Text = resta.ToString();
                lblResultado.Visible = true;
            }

            else if (txtOperando.Text == "*")
            {
                decimal multiplicacion = numero1 * num2;
                lblResultado.Text = multiplicacion.ToString();
                lblResultado.Visible = true;
            }

            else if (txtOperando.Text == "/")
            {
                if (num2 == 0)
                {
                    lblResultado.Text = "NO SE PUEDE DIVIDIR POR CERO";
                    lblResultado.Visible = true;
                }
                else
                {
                    decimal division = numero1 / num2;
                    lblResultado.Text = division.ToString();
                    lblResultado.Visible = true;
                }   
            }
            else
            {
                lblResultado.Text = "INGRESE UN OPERADOR VALIDO";
                lblResultado.Visible = true;
            }
        }
            
        
        }

    }
