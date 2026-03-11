using ClassFundProject.DbMysqlModels;

namespace ClassFundProject.Repos
{
    public class ClassFundRepo
    {
        //private readonly ClassfundSqliteContext _context = new ClassfundSqliteContext();
        private readonly OsztalypenzContext _context = new OsztalypenzContext();

        public int Count()
        {
            return _context.Classfunds.Count();
        }

        public List<Classfund> GetAll()
        {
            return _context.Classfunds.ToList();
        }

        public void Update(int id, int updatedMoney)
        {
            var result = _context.Classfunds.Find(id);
            if (result != null)
                return;
            result.Amount = updatedMoney;
            _context.Classfunds.Update(result);
            _context.SaveChanges();
        }
    }
}
