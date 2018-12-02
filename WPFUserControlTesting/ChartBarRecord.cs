using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUserControlTesting
{
    public class ChartBarRecord:BaseModel
    {
        public string ColumnName { get; set; }
        public int Value { get; set; }
        public IList<ChartBarRecord> ParentList { get; set; }
        public int IndexAtParent { get
            {
                return ParentList.IndexOf(this); 
            }
        }

    }
}
