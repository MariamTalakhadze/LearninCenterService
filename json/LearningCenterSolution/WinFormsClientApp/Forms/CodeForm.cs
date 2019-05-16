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
    public partial class CodeForm : Form
    {
        private string _Type;
        public string code;
        public SubjectDTO SubjectDTO;
        public CodeForm(string Type)
        {
            InitializeComponent();
            this._Type = Type;
            CommitButton.Text = Type;
        }
        private void CodeForm_Load(object sender, EventArgs e)
        {

        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            code = CodeTextBox.Text;
            switch (_Type)
            {
                case "Update":
                    AddOrEditSubjectForm addOrEditSubjectForm = new AddOrEditSubjectForm(code);
                    addOrEditSubjectForm.Show();
                    break;
                case "Delete":
                    HelpMethods.DeleteSubject(code);
                    
                    break;
                case "Find":
                    SubjectDTO subject = HelpMethods.GetSubjectByCode(code);
                    
                    this.SubjectDTO = subject;
                    break;
            }
            this.Close();
        }
    }
}
