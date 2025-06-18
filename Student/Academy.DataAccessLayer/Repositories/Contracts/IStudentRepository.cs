using Academy.DataAccessLayer.DataContext.Entities;


namespace Academy.DataAccessLayer.Repositories.Contracts
{
    public interface IStudentRepository :IRepositoryAsync<Student>
    {

        string OnlyStudent();

    }
}
