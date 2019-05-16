using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml.Serialization;

namespace WinFormsClientApp {
    public static class HelpMethods 
    {
        private static string url = ConfigurationSettings.AppSettings["MyTestXMLService"];

        public static TClass Deserialize<TClass>(string xml) where TClass : class, new() {
            var result = new TClass();

            xml = RemoveTypeTagFromXml(xml);

            var xmlSerializer = new XmlSerializer(typeof(TClass));
            using (TextReader textReader = new StringReader(xml)) {
                result = (TClass)xmlSerializer.Deserialize(textReader);
            }
            return result;
        }

        public static string RemoveTypeTagFromXml(string xml) {
            if (!string.IsNullOrEmpty(xml) && xml.Contains("xmlns")) {               
                xml = Regex.Replace(xml, @"xmlns(:\w+)?=""([^""]+)""|xsi(:\w+)?=""([^""]+)""", "");
            }
            return xml;
        }

        public static List<SubjectDTO> GetAllSubjects() {
            try {
                WebClient wc = new WebClient();
                wc.Encoding = UTF8Encoding.UTF8;
                var t = wc.DownloadString(url + "GetAllSubjects");
                List<SubjectDTO> fp = new JavaScriptSerializer().Deserialize<List<SubjectDTO>>(t);
                return fp;
            }
            catch (Exception ex) {
                return new List<SubjectDTO>();
            }
        }

        public static SubjectDTO GetSubjectByCode(String code) {
            try {
                WebClient wc = new WebClient();
                wc.Encoding = UTF8Encoding.UTF8;
                var t = wc.DownloadString(url + "GetSubjectByCode/" + code);
                SubjectDTO fp = new JavaScriptSerializer().Deserialize<SubjectDTO>(t);
                return fp;
            }
            catch (Exception ex) {
                return null;
            }
        }

        public static bool AddNewSubject(SubjectDTO subject) {
            try {
                string inputJson = (new JavaScriptSerializer()).Serialize(subject);

                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(new Uri(url + "AddNewSubject"));
                httpRequest.Accept = "application/json";
                httpRequest.ContentType = "application/json";
                httpRequest.Method = "POST";

                byte[] bytes = Encoding.UTF8.GetBytes(inputJson);

                using (Stream stream = httpRequest.GetRequestStream()) {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Close();
                }

                using (HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse()) {
                    using (Stream stream = httpResponse.GetResponseStream()) {
                        String result = (new StreamReader(stream)).ReadToEnd();
                        return Boolean.Parse(result);
                    }
                }
            } catch (Exception ex) {
                return false;
            }
        }

        public static bool UpdateSubject(SubjectDTO subject) {
            try {
                string inputJson = (new JavaScriptSerializer()).Serialize(subject);

                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(new Uri(url + "UpdateSubject"));
                httpRequest.Accept = "application/json";
                httpRequest.ContentType = "application/json";
                httpRequest.Method = "PUT";

                byte[] bytes = Encoding.UTF8.GetBytes(inputJson);

                using (Stream stream = httpRequest.GetRequestStream()) {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Close();
                }

                using (HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse()) {
                    using (Stream stream = httpResponse.GetResponseStream()) {
                        String result = (new StreamReader(stream)).ReadToEnd();
                        return Boolean.Parse(result);
                    }
                }
            }
            catch (Exception ex) {
                return false;
            }
        }

        public static bool DeleteSubject(String code) {
            try {
                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(new Uri(url + "DeleteSubject/"+code));
                httpRequest.Accept = "application/json";
                httpRequest.ContentType = "application/json";
                httpRequest.Method = "DELETE";                

                using (HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse()) {
                    using (Stream stream = httpResponse.GetResponseStream()) {
                        String result = (new StreamReader(stream)).ReadToEnd();
                        return Boolean.Parse(result);
                    }
                }
            }
            catch (Exception ex) {
                return false;
            }
        }
    }
}
