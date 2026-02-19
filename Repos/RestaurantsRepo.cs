using MyExam.Desktop.DbSqliteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam.Desktop.Repos
{
    public class RestaurantsRepo    //backend, linq desktop
    {
        private readonly RestaurantsContext _context = new RestaurantsContext();

        public int Count => _context.Restaurants.Count();

        public int RevenueCount => _context.Restaurants.Count(r => r.Income > 25000);

        public int RevenueLess => _context.Restaurants.Count(r => r.Income < 20000);

        public int NagyAnna => _context.Restaurants.Where(o => o.Owner == "Nagy Anna").Max(r => r.Income);

        //felkesz
        //public int KissGabor => _context.Restaurants.GroupBy(o => o.Owner == "Nagy Anna").Select(g => new { owner = g.Key, bevetel = Max.(g.Income) });

        public int BetweenRevenue => _context.Restaurants.Count(r => r.Income > 20000 && r.Income < 40000);

        //felkesz
        //public int SumSzaboLaszlo => _context.Restaurants.Sum(r => r.Income).Where(o => o.Owner == "Szabó László");
    }
}