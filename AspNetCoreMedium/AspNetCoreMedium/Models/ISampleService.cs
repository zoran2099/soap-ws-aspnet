using System.ServiceModel;
using Models;

namespace Models
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Test(string s);
        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
        [OperationContract]
        MyCustomModel TestCustomModel(MyCustomModel inputModel);
    }
}
