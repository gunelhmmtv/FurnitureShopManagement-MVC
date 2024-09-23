using FS.CoreLayer.Enums;
using FS.CoreLayer.Wrappers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.CoreLayer.Wrappers.Implementations
{
    public class ResponseDataResult<T> : ResponseResult, IResponseDataResult<T>
    {
        public ResponseDataResult(ResponseType responseType, string message) : base(responseType, message)
        {
        }

        public T Data { get ; set ; }
        public ResponseDataResult(T data) : base(ResponseType.SuccessResult,"Success")
        {
            Data = data;
        }
    }
}
