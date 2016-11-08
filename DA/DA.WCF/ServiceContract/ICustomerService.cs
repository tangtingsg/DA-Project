using DA.WCF.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DA.WCF.ServiceContract {

    [ServiceContract]
    public interface ICustomerService {

        [OperationContract]
        List<CustomerDC> GetAllCustomer();

        [OperationContract]
        CustomerDC GetCustomerById();
     }
}
