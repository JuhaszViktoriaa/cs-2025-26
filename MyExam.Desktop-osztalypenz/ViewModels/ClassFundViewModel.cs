using ClassFundProject.DbMysqlModels;
using ClassFundProject.Repos;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ClassFundProject.ViewModels
{
    public partial class ClassFundViewModel : ObservableObject
    {
        private readonly ClassFundRepo repo = new ClassFundRepo();

        [ObservableProperty]
        private string countText;

        [ObservableProperty]
        private ObservableCollection<Classfund> classFunds;

        [ObservableProperty]
        private Classfund selectedClassFunds;

        [ObservableProperty]
        private int updatedMoney;

        public ClassFundViewModel()
        {
            CountText = $"{repo.Count()} diák van az adatbázisban.";
            ClassFunds = new ObservableCollection<Classfund>(repo.GetAll());
        }

        partial void OnSelectedClassFundsChanged(Classfund value)
        {
            UpdatedMoney = value.Amount;
        }

        [RelayCommand]
        public void UpdateMoney()
        {
            repo.Update(SelectedClassFunds.Id, UpdatedMoney);
            ClassFunds = new ObservableCollection<Classfund>(repo.GetAll());
        }
    }
}
