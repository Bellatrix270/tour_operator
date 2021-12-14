using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour_operator.View
{
    public interface ILoginOperator : IView
    {
        string EmailOperator { get; set; }
        string PasswordOperator { get; set; }
        bool IsExistOperator { get; set; }
    }
}
