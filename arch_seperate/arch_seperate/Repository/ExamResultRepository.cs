using arch_seperate.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace arch_seperate.Repository
{
    public class ExamResultRepository : IExamResultRepository
    {
        private readonly BlogContext _blogContext;

        public ExamResultRepository(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        public async Task<IEnumerable<ExamResult>> GetOneAsync(string studentName, string subject, int marks)
        {
            //string studentName = dict.FirstOrDefault(d => d.Key.Contains("StudentName")).Value as string;
            //string subject = dict.FirstOrDefault(d => d.Key.Contains("Subject")).Value as string;
            //int marks = Convert.ToInt32(dict.FirstOrDefault(d => d.Key.Contains("Marks")).Value);
            //return await _blogContext.ExamResults.Where(x => x.StudentName ==).ToListAsync();
            return await _blogContext.ExamResults.Where(d => d.StudentName == studentName && d.Subject == subject && d.Marks == d.Marks).ToListAsync();
        }


        public async Task<IEnumerable<ExamResult>> GetSomeAsync(string studentName)
        {
            return await _blogContext.ExamResults.Where(x => x.StudentName == studentName).ToListAsync();
        }

        public async Task<IEnumerable<ExamResult>> GetAllAsync()
        {
            return await _blogContext.ExamResults.ToListAsync();
        }
        public async void Create(ExamResult examResult)
        {
            _blogContext.ExamResults.Add(examResult);
            await SaveChangesAsync();
        }

        public async void UpdateAsync(ExamResult examResult)
        {
            if (examResult == null)
            {
                throw new ArgumentNullException("examResult parameter can't be null");
            }
            var Exam = _blogContext.ExamResults.Where(x => x.StudentName == examResult.StudentName && x.Subject == examResult.Subject && x.Marks == examResult.Marks).FirstOrDefault();
            if(Exam == null)
            {
                
            }
            
            _blogContext.Entry(examResult).State = EntityState.Modified;
            await SaveChangesAsync();
        }

        public async void DeleteAsync(ExamResult examResult)
        {
            if (examResult == null)
            {
                throw new ArgumentNullException("examResult parameter can't be null");
            }
            _blogContext.Entry(examResult).State = EntityState.Deleted;
            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _blogContext.SaveChangesAsync();
        }

        public bool ExamResultExists(string studentName)
        {
            return _blogContext.ExamResults.Any(e => e.StudentName == studentName);
        }

    }
}
