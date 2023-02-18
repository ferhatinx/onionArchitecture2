using Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrappers
{
    public class GenericServiceResponse<T>
    {
        public T? Data { get; set; }
        public ResponseType  ResponseType { get; set; }
        public GenericServiceResponse()
        {

        }
        

        public GenericServiceResponse(T data)
        {
            Data = data;
        }
        public GenericServiceResponse(T data,ResponseType response)
        {
            Data = data;
            ResponseType = response;
        }
    }
}
