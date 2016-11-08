using DA.WCF.ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DA.WCF.DataContract;
using DA.Core;
using System.Web;

namespace DA.WCF.Service {

    public class CustomerService : ICustomerService {
        public List<CustomerDC> GetAllCustomer() {
            SystemContext db = new SystemContext();
            var customers = new List<CustomerDC>();
            var identity = ServiceSecurityContext.Current.PrimaryIdentity.Name;
            System.Diagnostics.Debug.Print(identity);
            System.Diagnostics.Debug.Print(">>> enter GetAllCustomer method.");
            System.Diagnostics.Debug.Print(">>> db: " + db.Database.Connection.ConnectionString);
            System.Diagnostics.Debug.Print(">>> result size: " + db.Customers.Count());
            foreach (var temp in db.Customers.ToList()) {
                var customer = new CustomerDC();
                customer.Name = temp.Name;
                customer.Fund = temp.Fund;
                customer.Profs = temp.Profs;
                customers.Add(customer);
            }
            return customers;
        }

        public CustomerDC GetCustomerById()
        {
            using (var db = new SystemContext())
            {
                var identity = ServiceSecurityContext.Current.PrimaryIdentity.Name;
                System.Diagnostics.Debug.Print(">>> db: " + db.Database.Connection.ConnectionString);
                System.Diagnostics.Debug.Print(">>> result size: " + db.Customers.Count());
                var temp = db.Customers.FirstOrDefault((cust) => cust.Identity.Equals(identity));
                if (temp != null)
                {
                    var customer = new CustomerDC();
                    customer.Identity = temp.Identity; 
                    customer.Name = temp.Name;
                    customer.Fund = temp.Fund;
                    customer.Profs = temp.Profs;
                    return customer;
                }
                return null;
            }
        }
    }
}