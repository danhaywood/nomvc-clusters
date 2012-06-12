using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NakedObjects;

namespace Demo.Dom.Payments
{
    public partial class Payment
    {
    
        #region Primitive Properties
        #region Id (Int32)
    [MemberOrder(100)]
        public virtual int  Id {get; set;}

        #endregion
        #region Amount (Decimal)
    [MemberOrder(110)]
        public virtual decimal  Amount {get; set;}

        #endregion
        #region PayeeCompoundKey (String)
    [MemberOrder(120)]
        public virtual string  PayeeCompoundKey {get; set;}

        #endregion

        #endregion
    }
}
