using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceApp 
{   
    [ServiceContract]
    public interface ISubjectsManagement 
    {
        [OperationContract]
        [WebGet(UriTemplate= "/GetAllSubjects", RequestFormat=WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json)]
        List<SubjectDTO> GetAllSubjects();

        [OperationContract]
        [WebGet(UriTemplate = "/GetSubjectByCode/{code}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        SubjectDTO GetSubjectByCode(string code);

        [OperationContract]
        [WebInvoke(Method="POST", UriTemplate = "/AddNewSubject", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool AddNewSubject(SubjectDTO subject);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "/UpdateSubject", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool UpdateSubject(SubjectDTO subject);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "/DeleteSubject/{code}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        bool DeleteSubject(string code);


    }    
}
