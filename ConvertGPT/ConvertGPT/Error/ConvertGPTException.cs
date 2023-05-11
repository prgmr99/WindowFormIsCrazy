using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT.Error
{

    internal class ConvertGPTException: Exception 
    {
        public ErrorCode ErrorCode { get; }

        public string ErrorMessage { 
            get {
                switch (ErrorCode) {
                    case ErrorCode.InvalidInput:
                        return "변환할 Code를 입력하세요.";
                    case ErrorCode.ToLanguageDeselected:
                        return "변환할 언어를 선택해주세요.";
                    default:
                        return "오류가 발생했습니다.";
                };
            }
        }

        public ConvertGPTException(ErrorCode errorCode)
        {
            ErrorCode = errorCode;
        }
    }
}
