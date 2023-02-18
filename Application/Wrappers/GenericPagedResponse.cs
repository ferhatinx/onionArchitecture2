using Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrappers
{
    public class GenericPagedResponse<T> : GenericServiceResponse<T>
    {
        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public GenericPagedResponse(T data) :base(data)
        {

        }
        public GenericPagedResponse(ResponseType response,T data) : base(data,response)
        {

        }
        public GenericPagedResponse()
        {
            PageNumber = 1;
            PageSize= 10;
        }
        public GenericPagedResponse(int pageNumber,int pageSize)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
