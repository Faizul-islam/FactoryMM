﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMM.ViewModels
{
    public class EmployeeEditViewModel : EmployeeCreateViewModel
    {
        public int EmpId { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
