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

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LblNumber1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            int Number1, Number2, result;

            try
            {
                Number1 = Convert.ToInt32(txtNumber1.Text);
                Number2 = Convert.ToInt32(txtNumber2.Text);
                result = Number1 + Number2;
                lblResumeType.Text = "Summe";
                lblResume.Text = Convert.ToString(result);

            }
            catch (Exception ex)
            {
                lblResumeType.Text = "Fehler";
                lblResumeType.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            lblResumeType.Text = "Ergebniss";
            lblResume.Text = "";
            txtNumber1.Text = "0";
            txtNumber2.Text = "0";
            txtNumber1.Focus();
            txtNumber1.SelectAll();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            int Number1, Number2, result;

            try
            {
                Number1 = Convert.ToInt32(txtNumber1.Text);
                Number2 = Convert.ToInt32(txtNumber2.Text);
                result = Number1 - Number2;
                lblResumeType.Text = "Differenz";
                lblResume.Text = Convert.ToString(result);

            }
            catch (Exception ex)
            {
                lblResumeType.Text = "Fehler";
                lblResumeType.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
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
                    lblResumeType.Text = "Quotient";
                    lblResume.Text = Convert.ToString(result);
                }

            }
            catch (Exception ex)
            {
                lblResumeType.Text = "Fehler";
                lblResumeType.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            int Number1, Number2, result;

            try
            {
                Number1 = Convert.ToInt32(txtNumber1.Text);
                Number2 = Convert.ToInt32(txtNumber2.Text);
                result = Number1 * Number2;
                lblResumeType.Text = "Produkt";
                lblResume.Text = Convert.ToString(result);

            }
            catch (Exception ex)
            {
                lblResumeType.Text = "Fehler";
                lblResumeType.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void BtnQuatrieren_Click(object sender, EventArgs e)
        {
            int Number1, Number2, result;
            

            try
            {
                Number1 = Convert.ToInt32(txtNumber1.Text);
                Number2 = Convert.ToInt32(txtNumber2.Text);
                result = Convert.ToInt32(Math.Pow(Convert.ToDouble(Number1), Convert.ToDouble(Number2)));
                lblResume.Text = Convert.ToString(result);

            }
            catch (Exception ex)
            {
                lblResumeType.Text = "Fehler";
                lblResumeType.Text = "Kein numerischer Wert";

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
                    result = Convert.ToInt32(Math.Pow(Convert.ToDouble(Number1),( 1/Convert.ToDouble(Number2))));
                    lblResume.Text = Convert.ToString(result);
                }

            }
            catch (Exception ex)
            {
                lblResumeType.Text = "Fehler";
                lblResumeType.Text = "Kein numerischer Wert";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }
    }
}
