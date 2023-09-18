using System;
using System.Collections.Generic;
using System.Text;

namespace Fomema.Model.users
{
	public class menudto
	{
        public int Id { get; set; }
        public int? parentId { get; set; }
        public int? menuId { get; set; }
        public string menuName { get; set; }
        public string controllerName { get; set; }
        public string actionName { get; set; }
        public string fontawesomeIcon { get; set; }
        public bool? view { get; set; }
        public bool? edit { get; set; }
        public bool? add { get; set; }
        public int? recStatus { get; set; }
        public int? createdby { get; set; }
        public DateTime? createdat { get; set; }
        public int? modifiedby { get; set; }
        public DateTime? modifiedat { get; set; }
    }
}
