using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSample.Models
{
    public interface ISchoolActions
    {
        School GetSchool(int id);
        IEnumerable<School> GetAllSchools();
        School NewSchool(School schoolData);
        School UpdateSchool(School schoolData);
        School DeleteSchool(int id);
    }
}
