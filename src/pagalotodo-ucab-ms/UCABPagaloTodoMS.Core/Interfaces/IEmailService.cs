﻿using System.Threading.Tasks;

namespace UCABPagaloTodoMS.Core.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}
