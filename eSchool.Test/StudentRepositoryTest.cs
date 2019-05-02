using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using eSchool.Domain;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eSchool.Tests
{
    [TestClass]
    public class StudentRepositoryTest: RepositoryTestBase
    {
        MockDbSet<Student> students;
        public void SetupData()
        {
            students = new MockDbSet<Student>(new List<Student>
            {
                new Student("Name1","Email1","ACCTMSHAH"),                
               new Student("Name2","Email2","ACCTMSHAH")
            });
        }
        [TestMethod]
        public async Task Add()
        {
            SetupData();
            Student newStudent = new Student("Name3", "Email3", "ACCTMSHAH");
            var result= await proxy.StudentService.Add(newStudent);
            result.Should().BeGreaterThan(0);
        }

        [TestMethod]
        public void Update()
        {
        }

        [TestMethod]
        public void GetById()
        {
        }
    }
}
