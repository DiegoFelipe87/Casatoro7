using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casatoro.Entities
{
    public class ResponseBase<T>
    { 
        public bool IsValid { get; set; }
        public string Message { get; set; }
        public T DataSingle { get; set; }
    }
}
