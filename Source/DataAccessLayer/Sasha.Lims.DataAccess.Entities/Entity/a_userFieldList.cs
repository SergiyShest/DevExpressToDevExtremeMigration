//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sasha.Lims.DataAccess.Entities.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class a_userFieldList
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> linkedTable_id { get; set; }
        public Nullable<int> branchRoot { get; set; }
        public Nullable<bool> isHierarchy { get; set; }
        public string sqlQuery { get; set; }
    }
}