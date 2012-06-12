using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NakedObjects;

namespace Demo.Dom.Customers
{
    public partial class Customer
    {
    
        #region Primitive Properties
        #region Id (Int32)
    [MemberOrder(100)]
        public virtual int  Id {get; set;}

        #endregion
        #region FirstName (String)
    [MemberOrder(110)]
        public virtual string  FirstName {get; set;}

        #endregion
        #region LastName (String)
    [MemberOrder(120)]
        public virtual string  LastName {get; set;}

        #endregion

        #endregion
    }
}
