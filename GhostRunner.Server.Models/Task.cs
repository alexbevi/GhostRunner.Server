﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace GhostRunner.Server.Models
{
    public class Task
    {
        [Required]
        public long ID { get; set; }

        [Required, MaxLength(38)]
        public String ExternalId { get; set; }

        [Required(ErrorMessage = " * Required")]
        public String Name { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public long ParentId { get; set; }

        [Required]
        public ItemType ParentType { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public DateTime? Started { get; set; }

        public DateTime? Completed { get; set; }

        public virtual User User { get; set; }

        public virtual Project Project { get; set; }

        public virtual ICollection<TaskScript> TaskScripts { get; set; }
    }
}
