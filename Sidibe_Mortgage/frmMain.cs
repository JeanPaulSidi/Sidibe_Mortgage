using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sidibe_Mortgage
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void DisplayDefaultView()
        {
            txtPrincipalAmountInput.Clear();
            rad15Years.Checked = false;
            rad30Years.Checked = false;
            radOther.Checked = false;
            txtOtherInput.Clear();
            cboInterestChoice.Text = string.Empty;
            lblMonthlyPayment.Text = string.Empty;
            txtPrincipalAmountInput.Focus();
        }

        public double CalculateNumberOfPayments() 
        {
            if (rad15Years.Checked) 
            {
                return (15 * 12);
            }
            if (rad30Years.Checked) 
            {
                return (30 * 12);
            }
            else 
            {
                return (double.Parse(txtOtherInput.Text) * 12);
            }
        }

        public double CalculateMonthlyInterestRate() 
        {
           return (double.Parse(cboInterestChoice.Text) / 1200);
        }
        private void txtPrincipalAmountInput_TextChanged(object sender, EventArgs e)
        {
            int Principal;

            if ( (!int.TryParse(txtPrincipalAmountInput.Text, out Principal) || (Principal < 0)) && txtPrincipalAmountInput.Text.Length != 0) 
            {
                string Message = (txtPrincipalAmountInput.Text + " is a non valid data. Input the principal amount as a whole number, please");
                string Title = "Jean Paul Sidibe : Mortgage Calculator";
                MessageBox.Show(Message, Title);
                txtPrincipalAmountInput.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DisplayDefaultView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Jean Paul Sidibe : Mortgage Calculator";
            
        }

        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherInput.Visible = radOther.Checked;
        }

        private void btnCalculatePayment_Click(object sender, EventArgs e)
        {
            double MonthlyInterestRate;
            double TotalInterest;
            double NumberOfPayments;
            decimal PrincipalAmount;
            double MonthlyMorgage;
            decimal TotalMonthlyMorgage;

            MonthlyInterestRate = CalculateMonthlyInterestRate();
            NumberOfPayments = CalculateNumberOfPayments();

            TotalInterest = 1 + MonthlyInterestRate;

            MonthlyMorgage = MonthlyInterestRate * Math.Pow(TotalInterest, NumberOfPayments) / (Math.Pow(TotalInterest, NumberOfPayments) - 1);
            PrincipalAmount = decimal.Parse(txtPrincipalAmountInput.Text);

            TotalMonthlyMorgage = (decimal) MonthlyMorgage * PrincipalAmount;
            lblMonthlyPayment.Text = "Monthly payment is " + TotalMonthlyMorgage.ToString("C");
        }
    }
}
