using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceApp
{
    public class SubjectsManagement : ISubjectsManagement
    {
        public bool AddNewSubject(SubjectDTO subject) 
        {
            return BusinessLogics.AddNewSubject(subject);
        }

        public bool DeleteSubject(string code) 
        {
            return BusinessLogics.DeleteSubject(code);
        }

        public List<SubjectDTO> GetAllSubjects() 
        {
            return BusinessLogics.GetAllSubjects();
        }

        public SubjectDTO GetSubjectByCode(string code) 
        {
            return BusinessLogics.GetSubjectByCode(code);
        }

        public bool UpdateSubject(SubjectDTO subject) 
        {
            return BusinessLogics.UpdateSubject(subject);
        }
    }
}
