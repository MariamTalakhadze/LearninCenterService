using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsClientApp.Forms
{
    public partial class AddOrEditSubjectForm : Form
    {
        SubjectDTO SubjectDTO=new SubjectDTO();
        public AddOrEditSubjectForm()
        {
            InitializeComponent();
            CommitButton.Text = "Add Subject";
        }

        public AddOrEditSubjectForm(string Code)
        {
            InitializeComponent();
            SubjectDTO SubjectResult = HelpMethods.GetSubjectByCode(Code);
            CodeTextBox.Text = Code;
            CodeTextBox.Enabled = false;
            NameTextBox.Text = SubjectResult.Name;
            DescriptionTextBox.Text = SubjectResult.Description;
            CreditsnumericUpDown.Value = SubjectResult.Credits;
            HoursNumericUpDown.Value = SubjectResult.Hours.Value;

            CommitButton.Text = "Update Subject";

        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            SubjectDTO.Code = CodeTextBox.Text;
            SubjectDTO.Name = NameTextBox.Text;
            SubjectDTO.Description = DescriptionTextBox.Text;
            SubjectDTO.Credits = (int)CreditsnumericUpDown.Value;
            SubjectDTO.Hours = (int)HoursNumericUpDown.Value;
            if (CommitButton.Text.Equals("Add Subject")){
                HelpMethods.AddNewSubject(SubjectDTO);
            }
            else
            {
                HelpMethods.UpdateSubject(SubjectDTO);
            }
            
            this.Hide();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
