﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostRunner.Server.Models
{
    public class ScheduleDetail
    {
        [Required]
        public long ID { get; set; }

        [Required]
        public String Name { get; set; }

        public String Value { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
