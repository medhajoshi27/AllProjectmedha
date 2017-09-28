using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEntities.Domain
{
    public class Info
    {
        public string status_href { get; set; }
    }

    public class Status
    {
        public int id { get; set; }
        public string name { get; set; }
        public Info _info { get; set; }
    }

    public class Info2
    {
        public string type_href { get; set; }
    }

    public class Type
    {
        public int id { get; set; }
        public string name { get; set; }
        public Info2 _info { get; set; }
    }

    public class Info3
    {
        public string contact_href { get; set; }
    }

    public class DefaultContact
    {
        public int? id { get; set; }
        public string name { get; set; }
        public Info3 _info { get; set; }
    }

    public class TimeZone
    {
        public int id { get; set; }
        public string name { get; set; }
        public object _info { get; set; }
    }

    public class Info4
    {
        public string taxCode_href { get; set; }
    }

    public class TaxCode
    {
        public int? id { get; set; }
        public string name { get; set; }
        public Info4 _info { get; set; }
    }

    public class BillingTerms
    {
        public int? id { get; set; }
        public string name { get; set; }
        public object _info { get; set; }
    }

    public class Info5
    {
        public string company_href { get; set; }
    }

    public class BillToCompany
    {
        public int? id { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
        public Info5 _info { get; set; }
    }

    public class Info6
    {
        public string site_href { get; set; }
    }

    public class BillingSite
    {
        public int? id { get; set; }
        public string name { get; set; }
        public Info6 _info { get; set; }
    }

    public class Info7
    {
        public string contact_href { get; set; }
    }

    public class BillingContact
    {
        public int? id { get; set; }
        public string name { get; set; }
        public Info7 _info { get; set; }
    }

    public class InvoiceDeliveryMethod
    {
        public int? id { get; set; }
        public string name { get; set; }
        public object _info { get; set; }
    }

    public class Info8
    {
        public string lastUpdated { get; set; }
        public string updatedBy { get; set; }
    }

    public class Company
    {
        public int? id { get; set; }
        public string identifier { get; set; }
        public string name { get; set; }
        public Status status { get; set; }
        public Type type { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public object country { get; set; }
        public string phoneNumber { get; set; }
        public string faxNumber { get; set; }
        public string website { get; set; }
        public int territoryId { get; set; }
        public int? marketId { get; set; }
        public string accountNumber { get; set; }
        public DefaultContact defaultContact { get; set; }
        public string dateAcquired { get; set; }
        public object sicCode { get; set; }
        public object parentCompany { get; set; }
        public double annualRevenue { get; set; }
        public int? numberOfEmployees { get; set; }
        public object ownershipType { get; set; }
        public TimeZone timeZone { get; set; }
        public string leadSource { get; set; }
        public bool leadFlag { get; set; }
        public bool unsubscribeFlag { get; set; }
        public object calendarId { get; set; }
        public object userDefinedField1 { get; set; }
        public object userDefinedField2 { get; set; }
        public object userDefinedField3 { get; set; }
        public object userDefinedField4 { get; set; }
        public object userDefinedField5 { get; set; }
        public object userDefinedField6 { get; set; }
        public object userDefinedField7 { get; set; }
        public object userDefinedField8 { get; set; }
        public object userDefinedField9 { get; set; }
        public object userDefinedField10 { get; set; }
        public object vendorIdentifier { get; set; }
        public object taxIdentifier { get; set; }
        public TaxCode taxCode { get; set; }
        public BillingTerms billingTerms { get; set; }
        public object invoiceTemplate { get; set; }
        public object pricingSchedule { get; set; }
        public object companyEntityType { get; set; }
        public BillToCompany billToCompany { get; set; }
        public BillingSite billingSite { get; set; }
        public BillingContact billingContact { get; set; }
        public InvoiceDeliveryMethod invoiceDeliveryMethod { get; set; }
        public string invoiceToEmailAddress { get; set; }
        public object invoiceCCEmailAddress { get; set; }
        public bool deletedFlag { get; set; }
        public object dateDeleted { get; set; }
        public object deletedBy { get; set; }
        public string mobileGuid { get; set; }
        public object currency { get; set; }
        public object territoryManager { get; set; }
        public Info8 _info { get; set; }
        public object customFields { get; set; }
    }
}
