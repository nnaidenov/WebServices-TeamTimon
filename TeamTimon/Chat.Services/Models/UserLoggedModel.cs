﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chat.Services.Models
{
    public class UserLoggedModel
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string SessionKey { get; set; }
    }
}