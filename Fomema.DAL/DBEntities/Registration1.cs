using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Fomema.DAL.DBEntities
{
    public partial class Registration1
    {
        public Registration1()
        {
            Fileupload = new HashSet<Fileupload>();
        }

        public int Id { get; set; }
        public DateTime? ShiftTimeIn { get; set; }
        public DateTime? ShiftTimeOut { get; set; }
        public DateTime? ActualTimeIn { get; set; }
        public DateTime? ActualTimeOut { get; set; }
        public DateTime? ActualOtHr { get; set; }
        public DateTime? Lateness { get; set; }
        public DateTime? EarlyOut { get; set; }
        public DateTime? RequestedTimeIn { get; set; }
        public DateTime? RequestedTimeOut { get; set; }
        public DateTime? RequestedOtHr { get; set; }
        public string Remarks { get; set; }
        public int? Status { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? ClockDate { get; set; }
        public string ClockDay { get; set; }
        public string Reason { get; set; }
        public string Formattach { get; set; }
        public string Guidfileattach { get; set; }
        public DateTime? RequestedLateness { get; set; }
        public DateTime? RequestedEarlyout { get; set; }

        public virtual Status1 StatusNavigation { get; set; }
        public virtual ICollection<Fileupload> Fileupload { get; set; }
    }
}
