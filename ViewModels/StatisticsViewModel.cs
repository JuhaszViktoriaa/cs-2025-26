using CommunityToolkit.Mvvm.ComponentModel;
using MyExam.Desktop.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam.Desktop.ViewModels
{
    public partial class StatisticsViewModel : ObservableObject
    {
        private readonly RestaurantsRepo _repo = new RestaurantsRepo();
        [ObservableProperty]
        private string countText;

        [ObservableProperty]
        private string revenueText;

        [ObservableProperty]
        private string revenuelessText;

        [ObservableProperty]
        private string nagyannaText;

        //[ObservableProperty]
        //private string kissgaborText;

        [ObservableProperty]
        private string betweenrevText;

        //[ObservableProperty]
        //private string szabolaszloText;

        public StatisticsViewModel()
        {
            CountText = $"{_repo.Count} db etterem van az adatbazisban.";
            RevenueText = $"{_repo.RevenueCount} db etterem bevetele nagyobb, mint 25 000.";
            RevenuelessText = $"{_repo.RevenueLess} db etterem teljes bevetele";
            NagyannaText = $"{_repo.NagyAnna} Ft a legmagasabb bevetel Nagy Anna ettermei kozt.";
            //kissgaborText = $"{_repo.KissGabor} Ft a legalacsonyabb bevetel Kiss Gabor ettermei kozt.";
            BetweenrevText = $"{_repo.BetweenRevenue} db etterem rendelkezik 20 000 Ft es 40 000 Ft kozti bevetellel.";
            //szabolaszloText = $"{_repo.SumSzaboLaszlo} Ft az osszes bevetele Szabo Laszlo ettermeinek.";
        }
    }
}
