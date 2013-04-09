using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.ServiceModel.Activation;

namespace RestFulExamen
{
    /// <summary>
    /// Basically this code is developed for HTTP GET, PUT, POST & DELETE operation.
    /// </summary>
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Students : IStudents
    {
        List<Student> objStudent = new List<Student>();
        int StudentCount = 0;

        public Student CreateStudent(Student createStudent)
        {
            createStudent.idBooster1 = (++StudentCount).ToString();
            objStudent.Add(createStudent);
            return createStudent;
        }

        public List<Student> GetAllStudent()
        {
            return objStudent.ToList();
        }

        public Student GetAStudent(string id)
        {
            return objStudent.FirstOrDefault(e => e.idBooster1.Equals(id));
        }

        public Student UpdateStudent(string id, Student updateStudent)
        {
            Student p = objStudent.FirstOrDefault(e => e.idBooster1.Equals(id));
            p.birthDate1 = updateStudent.birthDate1;
            p.firtsName1 = updateStudent.firtsName1;
            p.lastName1 = updateStudent.lastName1;
            return p;
        }

        public void DeleteStudent(string id)
        {
            objStudent.RemoveAll(e => e.idBooster1.Equals(id));
        }
    }
}
