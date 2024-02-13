namespace Sidibe_Mortgage
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.txtPrincipalAmountInput = new System.Windows.Forms.TextBox();
            this.lblTermsInYears = new System.Windows.Forms.Label();
            this.rad15Years = new System.Windows.Forms.RadioButton();
            this.rad30Years = new System.Windows.Forms.RadioButton();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.txtOtherInput = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.cboInterestChoice = new System.Windows.Forms.ComboBox();
            this.btnCalculatePayment = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(13, 13);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(147, 36);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal :";
            // 
            // txtPrincipalAmountInput
            // 
            this.txtPrincipalAmountInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipalAmountInput.Location = new System.Drawing.Point(153, 8);
            this.txtPrincipalAmountInput.Name = "txtPrincipalAmountInput";
            this.txtPrincipalAmountInput.Size = new System.Drawing.Size(243, 41);
            this.txtPrincipalAmountInput.TabIndex = 1;
            this.txtPrincipalAmountInput.TextChanged += new System.EventHandler(this.txtPrincipalAmountInput_TextChanged);
            // 
            // lblTermsInYears
            // 
            this.lblTermsInYears.AutoSize = true;
            this.lblTermsInYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermsInYears.Location = new System.Drawing.Point(19, 64);
            this.lblTermsInYears.Name = "lblTermsInYears";
            this.lblTermsInYears.Size = new System.Drawing.Size(215, 36);
            this.lblTermsInYears.TabIndex = 2;
            this.lblTermsInYears.Text = "Terms In Years";
            // 
            // rad15Years
            // 
            this.rad15Years.AutoSize = true;
            this.rad15Years.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad15Years.Location = new System.Drawing.Point(35, 104);
            this.rad15Years.Name = "rad15Years";
            this.rad15Years.Size = new System.Drawing.Size(159, 40);
            this.rad15Years.TabIndex = 3;
            this.rad15Years.TabStop = true;
            this.rad15Years.Text = "15 Years";
            this.rad15Years.UseVisualStyleBackColor = true;
            // 
            // rad30Years
            // 
            this.rad30Years.AutoSize = true;
            this.rad30Years.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad30Years.Location = new System.Drawing.Point(35, 151);
            this.rad30Years.Name = "rad30Years";
            this.rad30Years.Size = new System.Drawing.Size(159, 40);
            this.rad30Years.TabIndex = 4;
            this.rad30Years.TabStop = true;
            this.rad30Years.Text = "30 Years";
            this.rad30Years.UseVisualStyleBackColor = true;
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOther.Location = new System.Drawing.Point(35, 198);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(137, 40);
            this.radOther.TabIndex = 5;
            this.radOther.TabStop = true;
            this.radOther.Text = "Other...";
            this.radOther.UseVisualStyleBackColor = true;
            this.radOther.CheckedChanged += new System.EventHandler(this.radOther_CheckedChanged);
            // 
            // txtOtherInput
            // 
            this.txtOtherInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherInput.Location = new System.Drawing.Point(178, 198);
            this.txtOtherInput.Name = "txtOtherInput";
            this.txtOtherInput.Size = new System.Drawing.Size(219, 41);
            this.txtOtherInput.TabIndex = 6;
            this.txtOtherInput.Visible = false;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(35, 264);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(113, 36);
            this.lblInterest.TabIndex = 7;
            this.lblInterest.Text = "Interest";
            // 
            // cboInterestChoice
            // 
            this.cboInterestChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInterestChoice.FormattingEnabled = true;
            this.cboInterestChoice.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.cboInterestChoice.Location = new System.Drawing.Point(153, 256);
            this.cboInterestChoice.Name = "cboInterestChoice";
            this.cboInterestChoice.Size = new System.Drawing.Size(79, 44);
            this.cboInterestChoice.TabIndex = 8;
            // 
            // btnCalculatePayment
            // 
            this.btnCalculatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePayment.Location = new System.Drawing.Point(108, 322);
            this.btnCalculatePayment.Name = "btnCalculatePayment";
            this.btnCalculatePayment.Size = new System.Drawing.Size(309, 57);
            this.btnCalculatePayment.TabIndex = 9;
            this.btnCalculatePayment.Text = "Calculate Payment";
            this.btnCalculatePayment.UseVisualStyleBackColor = true;
            this.btnCalculatePayment.Click += new System.EventHandler(this.btnCalculatePayment_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(108, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 68);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(315, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 68);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyPayment.Location = new System.Drawing.Point(41, 483);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(0, 36);
            this.lblMonthlyPayment.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 553);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculatePayment);
            this.Controls.Add(this.cboInterestChoice);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.txtOtherInput);
            this.Controls.Add(this.radOther);
            this.Controls.Add(this.rad30Years);
            this.Controls.Add(this.rad15Years);
            this.Controls.Add(this.lblTermsInYears);
            this.Controls.Add(this.txtPrincipalAmountInput);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "frmMain";
            this.Text = "frnMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtPrincipalAmountInput;
        private System.Windows.Forms.Label lblTermsInYears;
        private System.Windows.Forms.RadioButton rad15Years;
        private System.Windows.Forms.RadioButton rad30Years;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.TextBox txtOtherInput;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.ComboBox cboInterestChoice;
        private System.Windows.Forms.Button btnCalculatePayment;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMonthlyPayment;
    }
}

