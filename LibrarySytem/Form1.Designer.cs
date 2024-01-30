namespace LibrarySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtIssueDate = new DateTimePicker();
            lblIssueDate = new Label();
            lblReturnDate = new Label();
            dtReturnDate = new DateTimePicker();
            cbxCountry = new ComboBox();
            lblCountry = new Label();
            label1 = new Label();
            label2 = new Label();
            lblPenalty = new Label();
            lblBusinessDays = new Label();
            lblCalculatedPenalty = new Label();
            lblCalculatedBusinessDays = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // dtIssueDate
            // 
            dtIssueDate.Location = new Point(128, 60);
            dtIssueDate.Name = "dtIssueDate";
            dtIssueDate.Size = new Size(200, 23);
            dtIssueDate.TabIndex = 0;
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Location = new Point(39, 66);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(60, 15);
            lblIssueDate.TabIndex = 1;
            lblIssueDate.Text = "Issue Date";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new Point(39, 117);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(69, 15);
            lblReturnDate.TabIndex = 3;
            lblReturnDate.Text = "Return Date";
            // 
            // dtReturnDate
            // 
            dtReturnDate.Location = new Point(128, 111);
            dtReturnDate.Name = "dtReturnDate";
            dtReturnDate.Size = new Size(200, 23);
            dtReturnDate.TabIndex = 2;
            // 
            // cbxCountry
            // 
            cbxCountry.FormattingEnabled = true;
            cbxCountry.Location = new Point(128, 166);
            cbxCountry.Name = "cbxCountry";
            cbxCountry.Size = new Size(121, 23);
            cbxCountry.TabIndex = 4;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(39, 174);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 15);
            lblCountry.TabIndex = 5;
            lblCountry.Text = "Country";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 20);
            label1.Name = "label1";
            label1.Size = new Size(204, 15);
            label1.TabIndex = 6;
            label1.Text = "Please provide the below information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 274);
            label2.Name = "label2";
            label2.Size = new Size(178, 15);
            label2.TabIndex = 7;
            label2.Text = "The calculated results are below:";
            // 
            // lblPenalty
            // 
            lblPenalty.AutoSize = true;
            lblPenalty.Location = new Point(39, 360);
            lblPenalty.Name = "lblPenalty";
            lblPenalty.Size = new Size(46, 15);
            lblPenalty.TabIndex = 9;
            lblPenalty.Text = "Penalty";
            // 
            // lblBusinessDays
            // 
            lblBusinessDays.AutoSize = true;
            lblBusinessDays.Location = new Point(39, 309);
            lblBusinessDays.Name = "lblBusinessDays";
            lblBusinessDays.Size = new Size(80, 15);
            lblBusinessDays.TabIndex = 8;
            lblBusinessDays.Text = "Business Days";
            // 
            // lblCalculatedPenalty
            // 
            lblCalculatedPenalty.AutoSize = true;
            lblCalculatedPenalty.Location = new Point(128, 360);
            lblCalculatedPenalty.Name = "lblCalculatedPenalty";
            lblCalculatedPenalty.Size = new Size(13, 15);
            lblCalculatedPenalty.TabIndex = 11;
            lblCalculatedPenalty.Text = "0";
            // 
            // lblCalculatedBusinessDays
            // 
            lblCalculatedBusinessDays.AutoSize = true;
            lblCalculatedBusinessDays.Location = new Point(128, 309);
            lblCalculatedBusinessDays.Name = "lblCalculatedBusinessDays";
            lblCalculatedBusinessDays.Size = new Size(13, 15);
            lblCalculatedBusinessDays.TabIndex = 10;
            lblCalculatedBusinessDays.Text = "0";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(39, 212);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(289, 23);
            btnCalculate.TabIndex = 12;
            btnCalculate.Text = "Calculate Penalty";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 450);
            Controls.Add(btnCalculate);
            Controls.Add(lblCalculatedPenalty);
            Controls.Add(lblCalculatedBusinessDays);
            Controls.Add(lblPenalty);
            Controls.Add(lblBusinessDays);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCountry);
            Controls.Add(cbxCountry);
            Controls.Add(lblReturnDate);
            Controls.Add(dtReturnDate);
            Controls.Add(lblIssueDate);
            Controls.Add(dtIssueDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtIssueDate;
        private Label lblIssueDate;
        private Label lblReturnDate;
        private DateTimePicker dtReturnDate;
        private ComboBox cbxCountry;
        private Label lblCountry;
        private Label label1;
        private Label label2;
        private Label lblPenalty;
        private Label lblBusinessDays;
        private Label lblCalculatedPenalty;
        private Label lblCalculatedBusinessDays;
        private Button btnCalculate;
    }
}