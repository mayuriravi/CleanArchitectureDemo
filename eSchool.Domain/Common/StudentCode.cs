using eSchool.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Domain
{
    public class StudentCode : ValueObject
    {
        public String Department { get; private set; }
        public String UserName { get; private set; }

        private StudentCode() { }

        public StudentCode(string code)
        {
            SetValue(code);
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            // Using a yield return statement to return each element one at a time
            yield return Department;
            yield return UserName;
           
        }
        public override string ToString()
        {
            return $"{Department}{UserName}";
        }
        
        private void SetValue(string code)
        {
            try
            {
                this.Department = code.Substring(0, 4);
                this.UserName = code.Substring(4 + 1);
            }
            catch (Exception ex)
            {
                throw new InvalidStudentCodeException(ex.Message, ex);
            }
        }
    }
}