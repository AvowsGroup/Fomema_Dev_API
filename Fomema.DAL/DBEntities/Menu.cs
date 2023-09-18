using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Fomema.DAL.DBEntities
{
    public partial class Menu
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string MenuName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string FontawesomeIcon { get; set; }
        public bool? View { get; set; }
        public bool? Edit { get; set; }
        public bool? Add { get; set; }
        public int? Recstatus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
