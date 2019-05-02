using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Application.Exceptions
{
    public class DisenrollmentCommentRequiredException: ApplicationException
    {
        public DisenrollmentCommentRequiredException():base("Disenrollment comment is required")
        { }
    }
}
