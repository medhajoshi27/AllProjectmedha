//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositoryLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContactPhone
    {
        public int ContactPhoneId { get; set; }
        public Nullable<int> ContactId { get; set; }
        public int PhoneTypeId { get; set; }
        public string Phone { get; set; }
        public string Ext { get; set; }
        public Nullable<bool> isPrimaryPhone { get; set; }
        public Nullable<bool> isDeleted { get; set; }
    
        public virtual ContactPhoneType ContactPhoneType { get; set; }
    }
}
