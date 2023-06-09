﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Data.Models
{
    public class RolePermission
    {
        public RolePermission(int roleId, int permId) 
        { 
           RoleId = roleId;
           PermissionId = permId;
        }

        public RolePermission(){}

        [Key, Column(Order = 0)]
        public int RoleId { get; set; }

        [Key, Column(Order = 1)]
        public int PermissionId { get; set; }
    }
}
