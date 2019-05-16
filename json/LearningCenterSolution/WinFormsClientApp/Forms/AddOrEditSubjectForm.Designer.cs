namespace WinFormsClientApp.Forms
{
    partial class AddOrEditSubjectForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.CreditsnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.HoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.CommitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CreditsnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(26, 65);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(22, 12, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(151, 12);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.CodeTextBox.TabIndex = 6;
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(22, 223);
            this.HoursLabel.Margin = new System.Windows.Forms.Padding(22, 12, 2, 0);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(35, 13);
            this.HoursLabel.TabIndex = 4;
            this.HoursLabel.Text = "Hours";
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.Location = new System.Drawing.Point(22, 171);
            this.CreditsLabel.Margin = new System.Windows.Forms.Padding(22, 12, 2, 0);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(39, 13);
            this.CreditsLabel.TabIndex = 3;
            this.CreditsLabel.Text = "Credits";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(151, 118);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(22, 118);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(22, 12, 2, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // CreditsnumericUpDown
            // 
            this.CreditsnumericUpDown.Location = new System.Drawing.Point(151, 171);
            this.CreditsnumericUpDown.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.CreditsnumericUpDown.Name = "CreditsnumericUpDown";
            this.CreditsnumericUpDown.Size = new System.Drawing.Size(99, 20);
            this.CreditsnumericUpDown.TabIndex = 9;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(151, 65);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // HoursNumericUpDown
            // 
            this.HoursNumericUpDown.Location = new System.Drawing.Point(151, 223);
            this.HoursNumericUpDown.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.HoursNumericUpDown.Name = "HoursNumericUpDown";
            this.HoursNumericUpDown.Size = new System.Drawing.Size(99, 20);
            this.HoursNumericUpDown.TabIndex = 10;
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(22, 12);
            this.CodeLabel.Margin = new System.Windows.Forms.Padding(22, 12, 2, 0);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(32, 13);
            this.CodeLabel.TabIndex = 0;
            this.CodeLabel.Text = "Code";
            // 
            // CommitButton
            // 
            this.CommitButton.Location = new System.Drawing.Point(24, 295);
            this.CommitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(83, 28);
            this.CommitButton.TabIndex = 12;
            this.CommitButton.Text = "Add";
            this.CommitButton.UseVisualStyleBackColor = true;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(151, 295);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(83, 28);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddOrEditSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 333);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CommitButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.CreditsnumericUpDown);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.HoursNumericUpDown);
            this.Controls.Add(this.CodeLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddOrEditSubjectForm";
            this.Text = "AddOrEditSubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.CreditsnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label CreditsLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.NumericUpDown CreditsnumericUpDown;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.NumericUpDown HoursNumericUpDown;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Button CommitButton;
        private System.Windows.Forms.Button CancelButton;
    }
}