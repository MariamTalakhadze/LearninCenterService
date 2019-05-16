using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WinFormsClientApp.Forms;

namespace WinFormsClientApp {
    public partial class frmMain : Form {

        public frmMain() {
            InitializeComponent();
        }

        private void TSMI_GetAllSubjects_Click(object sender, EventArgs e) {
            List<SubjectDTO> result = HelpMethods.GetAllSubjects();
            dtgView.DataSource = result;
        }

        private void TSMI_AddSubject_Click(object sender, EventArgs e)
        {
            AddOrEditSubjectForm AddOrEditSubjectForm = new AddOrEditSubjectForm();
            AddOrEditSubjectForm.Show();

        }

        private void TSMI_FindSubject_Click(object sender, EventArgs e) {
            CodeForm codeForm = new CodeForm("Find");
            if (codeForm.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
            {
                if (codeForm.SubjectDTO != null)
                {
                    dtgView.DataSource = new List<SubjectDTO>() { codeForm.SubjectDTO };
                }
            }   
        }

        private void TSMI_UpdateSubject_Click(object sender, EventArgs e) {
            
            CodeForm codeForm = new CodeForm("Update");
            codeForm.Show();
        }

        private void TSMI_DeleteSubject_Click(object sender, EventArgs e) {
            CodeForm codeForm = new CodeForm("Delete");
            codeForm.Show();

        }
    }
}
