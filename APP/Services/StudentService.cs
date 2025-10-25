using APP.Domain;
using APP.Models;
using CORE.APP.Models;
using CORE.APP.Services;
using Microsoft.EntityFrameworkCore;

namespace APP.Services
{
    public class StudentService : Service<Student>
    {
        public StudentService(DbContext db) : base(db)
        {

        }

        public List<StudentResponse> List()
        {
            var query = Query().Select(s => new StudentResponse
            {
                Id = s.Id,
                Guid = s.Guid,
                Name = s.Name,
                Surname = s.Surname,
                BirtDate = s.BirtDate,
                OverallGrade = s.OverallGrade,
                IsGraduated = s.IsGraduated,

                FullName = s.Name + " " + s.Surname,
                IsGraduatedF = s.IsGraduated ? "Graduated" : "Not Graduaded",
                OverallGradeF = s.OverallGrade.HasValue ? s.OverallGrade.Value.ToString("N1") : string.Empty /* " " */,
                BirthDateF = s.BirtDate.ToString("MM/dd/yyyy HH:mm:ss")


            });
            return query.ToList();
        }

        public StudentResponse Item(int id)
        {
            var entity = Query().FirstOrDefault(s => s.Id == id);
            if (entity == null)
            {
                return null;
            }


            return new StudentResponse()
            {
                Id = entity.Id,
                Guid = entity.Guid,
                Name = entity.Name,
                Surname = entity.Surname,
                BirtDate = entity.BirtDate,
                IsGraduated = entity.IsGraduated,
                OverallGrade = entity.OverallGrade,
                FullName = entity.Name + " " + entity.Surname,
                IsGraduatedF = entity.IsGraduated ? "Graduated" : "Not Graduaded",
                OverallGradeF = entity.OverallGrade.HasValue ? entity.OverallGrade.Value.ToString("N1") :
                string.Empty /* " " */,
                BirthDateF = entity.BirtDate.ToString("MM/dd/yyyy HH:mm:ss")
            };
        }

        public CommandResponse Create(StudentRequest request)
        {
            if (Query().Any(s => s.Name == request.Name.Trim() && s.Surname == request.Surname.Trim()))
                return Error("Student with same name and surname exist");

            var entity = new Student
            {
                Name = request.Name,
                Surname = request.Surname,
                BirtDate = request.BirtDate,
                IsGraduated = request.IsGraduated,
                OverallGrade = request.OverallGrade
            };
            Create(entity);
            return Success("Student created successfully.", entity.Id);

        }

    }
}
