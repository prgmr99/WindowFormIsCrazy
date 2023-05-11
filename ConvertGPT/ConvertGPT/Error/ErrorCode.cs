using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT.Error
{
    internal enum ErrorCode
    {
        FromLanguageDeselected,
        ToLanguageDeselected,
        EmptyInput,
        InvalidInput
    }

}
