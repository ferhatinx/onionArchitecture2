﻿using Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrappers
{
    public class BaseResponse
    {
        public int Id { get; set; }
        public ResponseType ResponseType { get; set; }
        public string? Message { get; set; }
    }
}
