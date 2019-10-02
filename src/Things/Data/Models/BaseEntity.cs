using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Things.Data.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string CreatedBy { get; set; }

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string UpdatedBy { get; set; }

        public bool Status { get; set; } = true;
    }
}
