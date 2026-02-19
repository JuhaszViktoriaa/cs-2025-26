using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyExam.Backend.Entity.DbMysqlModels;

namespace MyExam.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamResultsController : ControllerBase
    {
        private readonly MyexamContext _context = new MyexamContext();

        [HttpGet("avg-by-subject")]
        public async Task<IActionResult> GetAvgBySubject()
        {
            var results = await _context.FinalExams.GroupBy(f => f.Tantárgy).OrderBy(f => f.Key).
                Select(f => new { subject = f.Key, avggrade = Math.Round(f.Average(f => f.Jegy), 2) }).ToListAsync();
            return Ok(results);
        }

        [HttpGet("examresults/student-count-by-class")]
        public async Task<IActionResult> StudentCountByClass()
        {
            var result = await _context.FinalExams.GroupBy(f => f.Osztály).
                Select(g => new { name = g.Key, studentcount = g.Count() }).ToListAsync();
            return Ok(result);
        }

        public async Task<IActionResult> GetDistinctStudents()
        {
            var result = await _context.FinalExams.GroupBy(f => f.Osztály).OrderBy(f => f.Key).
                Select(f => new { name = f.Key, studentsname = f.Select(f => f.Név).Distinct().Count() }).ToListAsync();
            return Ok(result);
        }

        public async Task<IActionResult> GetAvgGrade()
        {
            var result = await _context.FinalExams.GroupBy(f => f.Osztály).OrderBy(f => f.Key).
                Select(f => new { subject = f.Key, avgclass = f.Average(f => f.Jegy) }).ToListAsync();
            return Ok(result);
        }
    }
}
