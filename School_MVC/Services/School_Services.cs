using School_MVC.Data;
using School_MVC.Models;

namespace School_MVC.Services
{

    public class School_Services : ISchoolInterface
    {
        private readonly IWebHostEnvironment _web_env;
        private readonly AppDbContext _dbcontext;
        public School_Services(IWebHostEnvironment web_env, AppDbContext dbcontext)
        {
            _web_env = web_env;
            _dbcontext = dbcontext;
        }
        public School Add(School newschool)
        {
            newschool.Id = Guid.NewGuid();
            _dbcontext.schools.Add(newschool);
            _dbcontext.SaveChanges();
            return newschool;

        }

        public void DeleteById(Guid id)
        {
            School schoola = _dbcontext.schools.FirstOrDefault(b => b.Id == id);
            _dbcontext.schools.Remove(schoola);
            _dbcontext.SaveChanges();
        }

        public List<School> GetAll()
        {
            return _dbcontext.schools.ToList();
        }

        public School GetById(Guid id)
        {
            return _dbcontext.schools.FirstOrDefault(b => b.Id == id); 
        }

        public School Update(School school)
        {
            _dbcontext.schools.Update(school);
            _dbcontext.SaveChanges();
            return school;
        }
    }
}
