using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMathOperations1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Berechent die Summe beider Werte wenn auf diesen Knopf gedrückt wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int number1, number2, result;

            /* Version 1 (Runtime Error)
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);
            result = number1 + number2;
            lblResult.Text = Convert.ToString(result);
            lblResultType.Text = "Summe";
            */

            /* Version 2 (Wert wird 0 gesetzt)
            Int32.TryParse(txtNumber1.Text, out number1);
            Int32.TryParse(txtNumber2.Text, out number2);
            result = number1 + number2;
            lblResult.Text = Convert.ToString(result);
            lblResultType.Text = "Summe";
            */

            try
            {
                number1 = Convert.ToInt32(txtNumber1.Text);
                number2 = Convert.ToInt32(txtNumber2.Text);
                result = number1 + number2;
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Summe";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        /// <summary>
        /// Setzt die Labels auf Standarteinstellungen zurück
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            

            lblResultType.Text = "Ergebniss";
            lblResult.Text = "";
            txtNumber1.Text = "0";
            txtNumber2.Text = "0";
            txtNumber1.Focus();
            txtNumber1.SelectAll();
        }

        
        private void LblTitle_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Rechent die Beiden Werte Minus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            int Number1, Number2, result;

            try
            {
                Number1 = Convert.ToInt32(txtNumber1.Text);
                Number2 = Convert.ToInt32(txtNumber2.Text);
                result = Number1 - Number2;
                lblResultType.Text = "Differenz";
                lblResult.Text = Convert.ToString(result);

            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResultType.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        /// <summary>
        /// Nimmt nummer 1 hoch nummer 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExpo_Click(object sender, EventArgs e)
        {
            int Number1, Number2, result;


            try
            {
                Number1 = Convert.ToInt32(txtNumber1.Text);
                Number2 = Convert.ToInt32(txtNumber2.Text);

                if (Number1==0 && Number2<=0)
                {
                    MessageBox.Show("Null hoch null oder einer Negativen Zahl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    result = Convert.ToInt32(Math.Pow(Convert.ToDouble(Number1), Convert.ToDouble(Number2)));
                    lblResult.Text = Convert.ToString(result);
                    lblResultType.Text = "Potenz";
                }

            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResultType.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void BtnMal_Click(object sender, EventArgs e)
        {
            int Number1, Number2, result;

            try
            {
                Number1 = Convert.ToInt32(txtNumber1.Text);
                Number2 = Convert.ToInt32(txtNumber2.Text);
                result = Number1 * Number2;
                lblResultType.Text = "Produkt";
                lblResult.Text = Convert.ToString(result);

            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResultType.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void BtnDividiert_Click(object sender, EventArgs e)
        {
            int Number1, Number2, result;

            try   //Meiner meinung würde hier ein double besser passen
            {
                Number1 = Convert.ToInt32(txtNumber1.Text);
                Number2 = Convert.ToInt32(txtNumber2.Text);

                if ((Number2 == 0) || (Number1 == 0))
                {
                    MessageBox.Show("Division durch 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    result = Number1 / Number2;
                    lblResultType.Text = "Quotient";
                    lblResult.Text = Convert.ToString(result);
                }

            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResultType.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void BtnWurzel_Click(object sender, EventArgs e)
        {

            int Number1, Number2, result;

            try   //Meiner meinung würde hier ein double besser passen
            {
                Number1 = Convert.ToInt32(txtNumber1.Text);
                Number2 = Convert.ToInt32(txtNumber2.Text);

                if ((Number2 == 0) || (Number1 < 0))
                {
                    MessageBox.Show("0-Wurzel oder Wurzel aus einer negativen Zahl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    result = Convert.ToInt32(Math.Pow(Convert.ToDouble(Number1), (1 / Convert.ToDouble(Number2))));
                    lblResult.Text = Convert.ToString(result);
                    lblResultType.Text = "Wurzel";
                }

            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResultType.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }
    }
}
