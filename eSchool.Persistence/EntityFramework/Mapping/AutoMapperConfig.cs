﻿using AutoMapper;
using AutoMapper.Configuration;
using eSchool.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Persistence.EntityFrameworkAdapter
{
    public class MappingEntity : Profile
    {
        public MappingEntity()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;
            //CreateMap<Student, StudentEntity>().ForMember(x => x.Enrollments, opt => opt.Ignore()).ReverseMap();
            //CreateMap<DepartmentEntity, Department>().ReverseMap();
            //CreateMap<CourseEntity, Course>().ReverseMap();
            //CreateMap<InstructorEntity, Instructor>().ReverseMap();
            //CreateMap<StudentEnrollmentEntity, StudentEnrollment>().ReverseMap();
            AddGlobalIgnore("CreatedDate");
            AddGlobalIgnore("CreatedBy");
            AddGlobalIgnore("ModifiedDate");
            AddGlobalIgnore("ModifiedBy");
             
        }
    }

}