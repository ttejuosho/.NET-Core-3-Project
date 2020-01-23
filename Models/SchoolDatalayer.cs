using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppSample.Models
{
    public class SchoolDatalayer : ISchoolActions
    {
        private readonly SchoolDbContext ctx;
        public SchoolDatalayer(SchoolDbContext ctx)
        {
            this.ctx = ctx;
        }
        public School NewSchool(School schoolData)
        {
            try
            {
                using (var tx = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        ctx.Schools.Add(schoolData);
                        ctx.SaveChanges();
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
                return schoolData;
            }
            catch
            {
                throw;
            }
        }

        public School GetSchool(int schoolId)
        {
            try
            {
                return ctx.Schools.Find(schoolId);
                //return ctx.Schools.Where(s => s.SchoolId == schoolId).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<School> GetAllSchools()
        {
            try
            {
                return ctx.Schools;
            }
            catch
            {
                throw;
            }
        }

        public School UpdateSchool(School schoolData)
        {
            try
            {
                var existing = ctx.Schools.Where(s => s.SchoolId == schoolData.SchoolId).FirstOrDefault();
                if (existing != null)
                {
                    var updatedRecord = ctx.Schools.Attach(schoolData);
                    updatedRecord.State = EntityState.Modified;
                    ctx.SaveChanges();
                    return schoolData;
                }
                else
                {
                    throw new ApplicationException();
                }

            }
            catch
            {
                throw;
            }
        }

        public School DeleteSchool(int schoolId)
        {
            try
            {
                using (var transaction = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        var existing = ctx.Schools.Where(s => s.SchoolId == schoolId).FirstOrDefault();
                        if (existing != null)
                        {
                            ctx.Schools.Remove(existing);
                            ctx.SaveChangesAsync();
                        }
                        else
                        {
                            throw new ApplicationException();
                        }
                        return existing;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
