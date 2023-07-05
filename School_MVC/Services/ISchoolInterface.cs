using School_MVC.Models;

namespace School_MVC.Services
{
    public interface ISchoolInterface
    {
        List<School> GetAll();
        School GetById(Guid id);
        School Add(School newschool);
        School Update(School school);
        void DeleteById(Guid id);
    }
}
