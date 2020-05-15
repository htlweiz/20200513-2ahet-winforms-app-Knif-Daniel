namespace BasicMathOperations1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblResumeType = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblResume = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPotenzieren = new System.Windows.Forms.Button();
            this.btnWurzel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(257, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(254, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Taschenrechner";
            this.lblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(79, 131);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(66, 25);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "Zahl 1";
            this.lblNumber1.Click += new System.EventHandler(this.LblNumber1_Click);
            // 
            // lblResumeType
            // 
            this.lblResumeType.AutoSize = true;
            this.lblResumeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumeType.Location = new System.Drawing.Point(79, 262);
            this.lblResumeType.Name = "lblResumeType";
            this.lblResumeType.Size = new System.Drawing.Size(99, 25);
            this.lblResumeType.TabIndex = 2;
            this.lblResumeType.Text = "Ergebniss";
            this.lblResumeType.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(79, 186);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(66, 25);
            this.lblNumber2.TabIndex = 3;
            this.lblNumber2.Text = "Zahl 2";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(240, 135);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 22);
            this.txtNumber1.TabIndex = 4;
            this.txtNumber1.Text = "0";
            this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(240, 189);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 22);
            this.txtNumber2.TabIndex = 5;
            this.txtNumber2.Text = "0";
            this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblResume
            // 
            this.lblResume.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.Location = new System.Drawing.Point(241, 262);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(99, 25);
            this.lblResume.TabIndex = 6;
            this.lblResume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPlus
            // 
            this.btnPlus.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(419, 132);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(33, 33);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.Location = new System.Drawing.Point(497, 189);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(33, 33);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(497, 132);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(33, 33);
            this.btnMinus.TabIndex = 9;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BtnMinus_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(419, 189);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(33, 33);
            this.btnDiv.TabIndex = 10;
            this.btnDiv.Text = ":";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnReset.AutoSize = true;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(268, 326);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 35);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnPotenzieren
            // 
            this.btnPotenzieren.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnPotenzieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotenzieren.Image = ((System.Drawing.Image)(resources.GetObject("btnPotenzieren.Image")));
            this.btnPotenzieren.Location = new System.Drawing.Point(569, 123);
            this.btnPotenzieren.Name = "btnPotenzieren";
            this.btnPotenzieren.Size = new System.Drawing.Size(50, 42);
            this.btnPotenzieren.TabIndex = 12;
            this.btnPotenzieren.UseVisualStyleBackColor = true;
            this.btnPotenzieren.Click += new System.EventHandler(this.BtnQuatrieren_Click);
            // 
            // btnWurzel
            // 
            this.btnWurzel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnWurzel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWurzel.Image = ((System.Drawing.Image)(resources.GetObject("btnWurzel.Image")));
            this.btnWurzel.Location = new System.Drawing.Point(569, 189);
            this.btnWurzel.Name = "btnWurzel";
            this.btnWurzel.Size = new System.Drawing.Size(50, 42);
            this.btnWurzel.TabIndex = 13;
            this.btnWurzel.UseVisualStyleBackColor = true;
            this.btnWurzel.Click += new System.EventHandler(this.BtnWurzel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWurzel);
            this.Controls.Add(this.btnPotenzieren);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblResumeType);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblResumeType;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPotenzieren;
        private System.Windows.Forms.Button btnWurzel;
    }
}

