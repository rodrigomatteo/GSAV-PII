using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAV.Entity.Util
{
    public class ReturnObject<T>
    {
        public string ErrorMessage { get; set; }
        public bool Success { get; set; }
        public T OneResult { get; set; }
        public List<T> ManyResults { get; set; }
        public Object Variant { get; set; }
        public Int32 RowCount { get; set; }
    }
}
