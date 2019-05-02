using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace eSchool.Domain
{
    public abstract class Entity
    {
       public int Id { get; set; }
    }
}
