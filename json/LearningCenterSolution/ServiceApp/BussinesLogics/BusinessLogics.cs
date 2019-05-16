using ServiceApp.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceApp
{
    public static class BusinessLogics 
    {
        public static List<SubjectDTO> GetAllSubjects() 
        {
            using (LCModel ent = new LCModel()) 
            {
                try
                {
                    var result = ent.Subjects.Where(i=> i.IsActive.HasValue && i.IsActive.Value==true).Select(i =>
                    new SubjectDTO
                    {
                        ID = i.ID,
                        Code = i.Code,
                        Credits = i.Credits,
                        Description = i.Description,
                        Hours = i.Hours,
                        Name = i.Name
                    }).ToList();

                    return result;
                } catch (Exception ex)
                {
                    return new List<SubjectDTO>();
                }
                
            }
        }

        public static SubjectDTO GetSubjectByCode(string code) 
        {
            using (LCModel ent = new LCModel()) 
            {
                if (!ent.Subjects.Any(i => i.Code.Equals(code)))
                    return null;

                var result = ent.Subjects.Where(i => i.Code.Equals(code))
                    .Select(i =>
                 new SubjectDTO {
                     ID = i.ID,
                     Code = i.Code,
                     Credits = i.Credits,
                     Description = i.Description,
                     Hours = i.Hours,
                     Name = i.Name,
                     IsActive = i.IsActive.HasValue? i.IsActive.Value:false
                 }).First();

                return result;
            }
        }

        public static bool AddNewSubject(SubjectDTO subject) {
            using (LCModel ent = new LCModel()) { 
                try
                {
                    if (ent.Subjects.Any(i=> i.Code.Equals(subject.Code))) 
                        throw new Exception("User code already exists");
                    Subject s = new Subject
                    {
                        Code = subject.Code,
                        Credits = subject.Credits,
                        Description = subject.Description,
                        Hours = subject.Hours,
                        Name = subject.Name,
                        IsActive = true
                    };
                    ent.Subjects.Add(s);
                    ent.SaveChanges();
                    return true;
                } catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool UpdateSubject(SubjectDTO subject)
        {
            using (LCModel ent = new LCModel())
            {
                try
                {
                    if (!ent.Subjects.Any(i => i.Code.Equals(subject.Code)))
                        throw new Exception("User code doesn't exists");
                    Subject s = ent.Subjects.Where(i => i.Code.Equals(subject.Code)).First();
                    s.Credits = subject.Credits;
                    s.Description = subject.Description;
                    s.Hours = subject.Hours;
                    s.Name = subject.Name;
                    ent.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool DeleteSubject(string code)
        {
            using (LCModel ent = new LCModel())
            {
                try
                {
                    if (!ent.Subjects.Any(i => i.Code.Equals(code)))
                        throw new Exception("User code doesn't exists");
                    Subject s = ent.Subjects.Where(i => i.Code.Equals(code)).First();
                    s.IsActive = false;
                    ent.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

    }
}