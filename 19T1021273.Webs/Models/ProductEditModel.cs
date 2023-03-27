using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _19T1021273.DomainModels;

namespace _19T1021273.Webs.Models
{
    public class ProductEditModel : Product
    {
        public List<ProductAttribute> ListOfAttributes { get; set; }

        public List<ProductPhoto> ListOfPhoto { get; set; }
    }
}