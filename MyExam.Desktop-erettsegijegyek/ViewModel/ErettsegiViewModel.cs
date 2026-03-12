using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using MyExam.Desktop_erettsegijegyek.DbMysqlModels;
using MyExam.Desktop_erettsegijegyek.Repo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam.Desktop_erettsegijegyek.ViewModel
{
    public partial class ErettsegiViewModel : ObservableObject
    {
        private readonly ErettsegiRepo _repo = new ErettsegiRepo();

        [ObservableProperty]
        private string countText;

        [ObservableProperty]
        private string minJegyText;

        [ObservableProperty]
        private string maxJegyText;

        [ObservableProperty]
        private string avgJegyText;

        [ObservableProperty]
        private string avgMagyarJegyText;

        [ObservableProperty]
        private string avg13CMagyarJegyText;

        [ObservableProperty]
        private string avg13BMatJegyText;

        [ObservableProperty]
        private string avg13BMaxJegyText;

        [ObservableProperty]
        private string avg13BMinJegyText;

        [ObservableProperty]
        private string toListTanulonevekText;

        [ObservableProperty]
        private string avgNagyAnnaText;

        [ObservableProperty]
        private ObservableCollection<Erettsegi> erettsegis;

        [ObservableProperty]
        private Erettsegi selectedErettsegi;

        [ObservableProperty]
        private int updatedJegy;

        public ErettsegiViewModel()
        {
            CountText = $" {_repo.Count()} adat van az adatbazisban.";
            Erettsegis = new ObservableCollection<Erettsegi>(_repo.GetAll());

            MinJegyText = $" 01. feladat: {_repo.MinJegy} Legkisebb jegy az összes eredményből.";
            MaxJegyText = $" 02. feladat: {_repo.MaxJegy} Legnagyobb jegy az összes eredményből.";
            AvgJegyText = $" 03. feladat: {_repo.AvgJegy} Összes jegy átlaga (minden tantárgy, minden diák).";
            AvgMagyarJegyText = $" 04. feladat: {_repo.AvgMagyarJegy} Magyar érettségi átlagjegy.";
            Avg13CMagyarJegyText = $" 05. feladat: {_repo.Avg13CMagyarJegy} 13.c átlaga magyarból.";
            Avg13BMatJegyText = $" 06. feladat: {_repo.Avg13BMatJegy} Matematika érettségi jegyek átlaga 13.b-ben.";
            Avg13BMaxJegyText = $" 07. feladat: {_repo.Avg13BMaxJegy} 13.b osztály legjobb jegye.";
            Avg13BMinJegyText = $" 08. feladat: {_repo.Avg13BMinJegy} 13.c osztály legrosszabb jegye Matematika tantárgyból.";
            ToListTanulonevekText = $" 09. feladat: {_repo.ToListTanulonevek} Különböző tanulónevek listája (név csak egyszer szerepel).";
            AvgNagyAnnaText = $" 10. feladat: {_repo.AvgNagyAnna} „Nagy Anna” átlagjegye a két tantárgyból.";
        }

        partial void OnSelectedErettsegiChanged(Erettsegi value)
        {
            UpdatedJegy = value.Jegy;
        }

        [RelayCommand]
        public void UpdateJegy()
        {
            _repo.Update(SelectedErettsegi.Id, UpdatedJegy);
            Erettsegis = new ObservableCollection<Erettsegi>(_repo.GetAll());
        }
    }
}