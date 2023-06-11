﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCABPagaloTodoMS.Application.Exceptions
{
    public class UserNotFoundException: Exception
    {
        public UserNotFoundException( string userName) : base($"No se pudo encontrar el Usuario de nombre {userName}")
        {
            UserName =userName; 
        }

        public string UserName { get;}
    }
}
