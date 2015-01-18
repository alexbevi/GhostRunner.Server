﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GhostRunner.Server.Models
{
    public class TaskScriptParameter
    {
        [Required]
        public long ID { get; set; }

        [Required]
        public String Name { get; set; }

        public String Value { get; set; }

        public virtual TaskScript TaskScript { get; set; }
    }
}
