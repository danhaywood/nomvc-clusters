using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using NakedObjects;
using NakedObjects.Services;

//Namespace must match that of the auto-generated partial class
namespace Demo.Dom.Payments
{
    //Use this partial class to define actions for the Payment class.
    //Also for methods to enrich the behaviour of properties - such as Validate,
    //Default, or Choices and for class-level attributes such as <IconName>.
    [MetadataType(typeof(Payment_Metadata))]
    public partial class Payment
    {

        #region Injected Services
        	// This region should contain properties to hold references to any services required by the
        	// object.  Use the 'injs' shortcut to add a new service; 'injc' to add an injected Container
        public IObjectFinder ObjectFinder { set; protected get; }

        #endregion

        #region Life Cycle Methods
        	// This region should contain any of the 'life cycle' convention methods (such as
        	// Created(), Persisted() etc) called by the framework at specified stages in the lifecycle.


        #endregion

        public string Title()
        {
            var t = new TitleBuilder();
            if (PayeeCompoundKey != null)
            {
                t.Append(Payee.Title());
            }
            t.Append(Amount);
            return t.ToString();
        }

        [NotPersisted]
        public IPayee Payee
        {
            get { return PayeeCompoundKey == null? null: ObjectFinder.FindObject<IPayee>(PayeeCompoundKey); }
            set { PayeeCompoundKey = ObjectFinder.GetCompoundKey(value); }
        }
    }

    #region 'Buddy class'
    //This is the so-called 'buddy class' for Payment.  It should have the 
    //same properties as the auto-generated partial Payment class, to which 
    //property-level attributes such as <Hidden> may be added.
    public class Payment_Metadata
    {

        [Hidden]
        public Int32 Id { get; set; }

        [Hidden]
        public string PayeeCompoundKey { get; set; }
    }
    #endregion

}