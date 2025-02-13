using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;
using Kreta.Shared.Models.Entites;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.SchoolSubjects
{
    public partial class SubjectsManagmentViewModel : BaseViewModel
    {
        private readonly ISubjectHttpService _httpService;

        //2. A lekért adatok ebben az adatstruktúrában jelennek meg majd a view-n
        [ObservableProperty]
        private ObservableCollection<Subject> _subjects = new ObservableCollection<Subject>();
        public SubjectsManagmentViewModel()
        {

        }

        //1.b konstruktorban injektáljuk a ISubjectHttpService
        public SubjectsManagmentViewModel(ISubjectHttpService? httpService)
        {
            _httpService = httpService ?? throw new ArgumentNullException(nameof(httpService));
        }

        //1.feladat Tantárgyak adatainak lekérése a backendről (vizsgaremek)
        //1.a Adatok menüpont kiválasztására jelenjenek meg: InitializeAsync
        public override async Task InitializeAsync()
        {
            await UpdateViewAsync();
            await base.InitializeAsync();
        }

        //1.c Adatok bekérése backendről
        private async Task UpdateViewAsync()
        {
            //1.d HttpServicen keresztül backend hívás
            List<Subject> subjects = await _httpService.GetAllAsync();
            //2.a A megérkezett adatokkal újra létrehozzuk a Subjects ObservableCollection
            Subjects = new ObservableCollection<Subject>(subjects);
        }
    }
}
