using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eSchool.Persistence.EntityFramework.Entities
{
    public abstract class IdEntity:BaseEntity
    {
        public int Id { get; set; }
    }
}
