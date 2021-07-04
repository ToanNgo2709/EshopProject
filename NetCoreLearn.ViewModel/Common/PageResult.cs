using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreLearn.ViewModel.Common
{
    public class PageResult<Type>
    {
        public int TotalRecord { get; set; }
        public List<Type> Items { get; set; }
    }




}
