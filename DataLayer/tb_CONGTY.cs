//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_CONGTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_CONGTY()
        {
            this.tb_NHANVIEN = new HashSet<tb_NHANVIEN>();
        }
    
        public int MACTY { get; set; }
        public string TENCTY { get; set; }
        public string DIENTHOAI { get; set; }
        public string EMAIL { get; set; }
        public string DIACHI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_NHANVIEN> tb_NHANVIEN { get; set; }
    }
}
