using MyExam.Desktop_erettsegijegyek.DbMysqlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam.Desktop_erettsegijegyek.Repo
{
    public class ErettsegiRepo
    {
        private readonly ErettsegijegyekContext _context = new ErettsegijegyekContext();
        //public readonly ErettsegiRepo _repo = new ErettsegiRepo();

        public int Count()
        {
            return _context.Erettsegis.Count();
        }

        public List<Erettsegi> GetAll()
        {
            return _context.Erettsegis.ToList();
        }

        //1. Legkisebb jegy az összes eredményből
        public int MinJegy()
        {
            return _context.Erettsegis.Min(e => e.Jegy);
        }

        //2. Legnagyobb jegy az összes eredményből
        public int MaxJegy()
        {
            return _context.Erettsegis.Max(e => e.Jegy);
        }

        //3. Összes jegy átlaga (minden tantárgy, minden diák)
        public int AvgJegy()
        {
            return (int)_context.Erettsegis.Average(e => e.Jegy);
        }

        //4. Magyar érettségi átlagjegy
        public int AvgMagyarJegy()
        {
            return (int)_context.Erettsegis.Where(e => e.Tantárgy == "Magyar").Average(e => e.Jegy);
        }

        //5. 13.c átlaga magyarból
        public int Avg13CMagyarJegy()
        {
            return (int)_context.Erettsegis.Where(e => e.Tantárgy == "Magyar" && e.Osztály == "13.c").Average(e => e.Jegy);
        }

        //6. Matematika érettségi jegyek átlaga 13.b-ben

        public int Avg13BMatJegy()
        {
            return (int)_context.Erettsegis.Where(e => e.Tantárgy == "Matematika" && e.Osztály == "13.b").Average(e => e.Jegy);
        }

        //7. 13.b osztály legjobb jegye

        public int Avg13BMaxJegy()
        {
            return _context.Erettsegis.Where(e => e.Osztály == "13.b").Max(e => e.Jegy);
        }

        //8. 13.c osztály legrosszabb jegye Matematika tantárgyból
        public int Avg13BMinJegy()
        {
            return _context.Erettsegis.Where(e => e.Osztály == "13.b").Min(e => e.Jegy);
        }

        //9. Különböző tanulónevek listája (név csak egyszer szerepeljen)

        public List<Erettsegi> ToListTanulonevek()
        {
            return _context.Erettsegis.Where(e => e.Név != "").OrderByDescending(e => e.Név).ToList();
        }

        //10. „Nagy Anna” átlagjegye a két tantárgyból

        public int AvgNagyAnna()
        {
            return (int)_context.Erettsegis.Where(e => e.Név == "Nagy Anna" && (e.Tantárgy == "Matematika" && e.Tantárgy == "Magyar")).Average(e => e.Jegy);
        }

        public void Update(int id, int updatedJegy)
        {
            var eredmeny = _context.Erettsegis.Find(id);
            if (eredmeny != null)
                return;
            eredmeny.Jegy = updatedJegy;
            _context.Erettsegis.Update(eredmeny);
            _context.SaveChanges();
        }
    }
}
