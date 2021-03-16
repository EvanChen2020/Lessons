using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 菜单节点
    /// </summary>
   public class TVNode
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuCode { get; set; }
        public string ParentId { get; set; }

    }
}
