namespace WinFormsClientApp.Forms
{
    partial class CodeForm
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
            this.CodeLabel = new System.Windows.Forms.Label();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.CommitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(36, 33);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(41, 17);
            this.CodeLabel.TabIndex = 0;
            this.CodeLabel.Text = "Code";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(103, 33);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(162, 22);
            this.CodeTextBox.TabIndex = 1;
            // 
            // CommitButton
            // 
            this.CommitButton.Location = new System.Drawing.Point(103, 87);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(107, 33);
            this.CommitButton.TabIndex = 2;
            this.CommitButton.Text = "Update";
            this.CommitButton.UseVisualStyleBackColor = true;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 133);
            this.Controls.Add(this.CommitButton);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.CodeLabel);
            this.Name = "CodeForm";
            this.Text = "CodeForm";
            this.Load += new System.EventHandler(this.CodeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Button CommitButton;
    }
}