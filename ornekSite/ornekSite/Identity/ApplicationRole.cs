﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ornekSite.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Description { get; set; }
        public ApplicationRole()
        {

        }
        public ApplicationRole(string rolename, string description)
        {
            this.Description = description;
        }
    }
}