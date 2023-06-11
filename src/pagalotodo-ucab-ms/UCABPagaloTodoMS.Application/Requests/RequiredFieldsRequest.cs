﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCABPagaloTodoMS.Application.Requests
{
    public class RequiredFieldsRequest
    {
        public string? FieldName { get; set; }
        public string? Content { get; set; }
        public bool? isNumber { get; set; }
        public bool? isString { get; set; }
        public string? Length { get; set; }
    }
}
