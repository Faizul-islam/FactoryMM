﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.ViewModels.IdentityViewModel
{
    public class CreateRoleVIewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
