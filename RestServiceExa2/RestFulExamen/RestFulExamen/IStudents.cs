using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestFulExamen
{
    #region Student Entity
    [DataContract]
    public class Student
    {
        [DataMember]
        public string birthDate1;
        [DataMember]
        public string firtsName1;
        [DataMember]
        public string idBooster1;
        [DataMember]
        public string lastName1;

    }
    #endregion


    #region IStudents Interface
    [ServiceContract]
    public interface IStudents
    {
        //POST operation
        [OperationContract]
        [WebInvoke(UriTemplate = "", Method = "POST")]
        Student CreateStudent(Student createStudent);

        //Get Operation
        [OperationContract]
        [WebGet(UriTemplate = "")]
        List<Student> GetAllStudent();
        [OperationContract]
        [WebGet(UriTemplate = "{id}")]
        Student GetAStudent(string id);

        //PUT Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        Student UpdateStudent(string id, Student updateStudent);

        //DELETE Operation
        [OperationContract]
        [WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        void DeleteStudent(string id);

    }
    #endregion

}




