using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Persistence
{
    public class BaseEntity
    {

        [IgnoreMap]
        public DateTime CreatedDate { get; set; }

        [IgnoreMap]
        public int CreatedBy { get; set; }

        [IgnoreMap]
        public DateTime ModifiedDate { get; set; }

        [IgnoreMap]
        public int ModifiedBy { get; set; }

        public BaseEntity()
        {
            CreatedBy = 0;
            CreatedDate = DateTime.MinValue;
            ModifiedBy = 0;
            ModifiedDate = DateTime.MinValue;
        }
    }
}
