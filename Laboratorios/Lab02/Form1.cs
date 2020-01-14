using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class lab02Form : Form
    {
        public lab02Form()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valorCompra = 0, valorPago = 0, resto = 0;

                valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
                valorPago = Convert.ToDecimal(valorPagoTextBox.Text);

                resto = valorPago - valorCompra;

                trocoLabel.Text = resto.ToString("C2");

                int moedas1 = (int)(resto / 1);
                resto = resto % 1;
                moedas1Label.Text = moedas1.ToString();

                int moedas050 = (int)(resto / 0.5m);
                resto = resto % 0.5m;
                moedas050Label.Text = moedas050.ToString();

                int moedas025 = (int)(resto / 0.25m);
                resto = resto % 0.25m;
                moedas025Label.Text = moedas025.ToString();

                int moedas010 = (int)(resto / 0.10m);
                resto = resto % 0.1m;
                moedas010Label.Text = moedas010.ToString();

                int moedas005 = (int)(resto / 0.05m);
                resto = resto % 0.05m;
                moedas005Label.Text = moedas005.ToString();

                int moedas001 = (int)(resto / 0.01m);
                resto = resto % 0.01m;
                moedas001Label.Text = moedas001.ToString();                

            }
            catch (FormatException)
            {
                MessageBox.Show("Favor digitar apenas numeros");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Numero informado extenso demais para calcular");
            }
            finally
            {
                valorCompraTextBox.Focus();

                valorCompraTextBox.SelectAll();
            }
        }
    }
}