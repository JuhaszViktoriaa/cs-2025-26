using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DbMysqlModels;
using WpfApp1.Repo;

namespace WpfApp1.ViewModel
{
    public partial class TripViewModel :  ObservableObject
    {
        private TripRepo _repo = new TripRepo();

        [ObservableProperty]
        public string allTripsCount = string.Empty;

        [ObservableProperty]
        public string femaleCount = string.Empty;

        [ObservableProperty]
        public string maleCount = string.Empty;

        [ObservableProperty]
        public string sumDeposit = string.Empty;

        [ObservableProperty]
        public string countZeroDeposit = string.Empty;

        public TripViewModel()
        {
            AllTripsCount = $"1. - {_repo.AllTripsCount} db kirandulast rogzitettek.";
            FemaleCount = $"2. - {_repo.FemaleCount} no vett reszt a kirandulasokon.";
            MaleCount = $"3. - {_repo.MaleCount} ferfi vett reszt a kirandulasokon.";
            SumDeposit = $"4. - {_repo.SumDeposit} ft az osszes depozit osszege.";
            CountZeroDeposit = $"5. - {_repo.CountZeroDeposit} db 0 ft erteku depozit van jelenleg.";
        }
    }
}
