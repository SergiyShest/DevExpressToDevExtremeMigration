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
    
    public partial class vRecomendateIndex
    {
        public string ServerName { get; set; }
        public string DBName { get; set; }
        public string Affected_table { get; set; }
        public Nullable<double> index_advantage { get; set; }
        public int group_handle { get; set; }
        public Nullable<long> unique_compiles { get; set; }
        public Nullable<System.DateTime> last_user_seek { get; set; }
        public Nullable<System.DateTime> last_user_scan { get; set; }
        public Nullable<double> avg_total_user_cost { get; set; }
        public Nullable<double> avg_user_impact { get; set; }
        public Nullable<long> system_seeks { get; set; }
        public Nullable<System.DateTime> last_system_scan { get; set; }
        public Nullable<System.DateTime> last_system_seek { get; set; }
        public Nullable<double> avg_total_system_cost { get; set; }
        public Nullable<double> avg_system_impact { get; set; }
        public int index_group_handle { get; set; }
        public int index_handle { get; set; }
        public short database_id { get; set; }
        public int object_id { get; set; }
        public string equality_columns { get; set; }
        public string inequality_columns { get; set; }
        public string statement { get; set; }
        public Nullable<int> K { get; set; }
        public string Keys { get; set; }
        public string include { get; set; }
        public string sql_statement { get; set; }
        public Nullable<long> user_seeks { get; set; }
        public Nullable<long> user_scans { get; set; }
        public Nullable<long> est_impact { get; set; }
        public Nullable<int> SecondsUptime { get; set; }
    }
}