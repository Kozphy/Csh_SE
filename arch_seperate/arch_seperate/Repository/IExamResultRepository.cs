using arch_seperate.Models;

namespace arch_seperate.Repository
{
    public interface IExamResultRepository 
    {
        void Create(ExamResult examResult);
        void UpdateAsync(ExamResult examResult);
        void DeleteAsync(ExamResult examResult);
        bool ExamResultExists(string studentName);

        Task<IEnumerable<ExamResult>> GetOneAsync(string studentName, string subject, int marks);

        Task<IEnumerable<ExamResult>> GetSomeAsync(string studentName);
        Task<IEnumerable<ExamResult>> GetAllAsync();
        Task SaveChangesAsync();
    }
}
