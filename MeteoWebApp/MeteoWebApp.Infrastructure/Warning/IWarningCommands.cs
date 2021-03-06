﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoWebApp.Infrastructure.Warning
{
    public interface IWarningCommands
    {
        void DeleteWarning(int id);
        void CreateWarning(string title, string text, string createdBy, DateTimeOffset createdOn);
    }
}
