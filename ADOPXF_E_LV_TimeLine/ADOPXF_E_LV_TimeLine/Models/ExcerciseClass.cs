﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ADOPXF_E_LV_TimeLine.Models
{
    public class ExerciseClass
    {
        public DateTime ClassTime { get; set; }
        public string ClassName { get; set; }
        public string Instructor { get; set; }

        public bool IsLast { get; set; } = false;
    }
}
