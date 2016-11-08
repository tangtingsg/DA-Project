using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DA.Core.Model {
    public abstract class BaseEntity : IEntity {

        public BaseEntity() {
            Id = Guid.NewGuid().ToString();
        }

        [Key, MaxLength(32)]
        public string Id { set; get; }
    }
}