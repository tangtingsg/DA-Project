using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DA.Core.Model {
    public class Customer : BaseEntity {

        public Customer() : base() { }
        public string Identity { get; set; }
        public string Name { get; set; }
        public string Fund { set; get; }
        public string Profs { set; get; }
    }
}