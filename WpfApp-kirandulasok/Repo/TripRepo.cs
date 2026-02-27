using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DbMysqlModels;

namespace WpfApp1.Repo
{
    public class TripRepo
    {
        public readonly TripContext _context = new TripContext();
        public int AllTripsCount => _context.Trips.Count(t => t.Id !=0);
        public int FemaleCount => _context.Trips.Count(t => t.Gender == "Female");
        public int MaleCount => _context.Trips.Count(t => t.Gender == "Male");
        public int SumDeposit => _context.Trips.Sum(t => t.Desposit);
        public int CountZeroDeposit => _context.Trips.Count(t => t.Desposit < 1);
    }
}
