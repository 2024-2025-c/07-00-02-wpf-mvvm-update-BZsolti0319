using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Services;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.SchoolSubjects
{
    public partial class SubjectsManagmentViewModel : BaseViewModel
    {
        private readonly ISubjectHttpService _httpService;

        //1.feladat Tantárgyak adatainak lekérése a backendről (vizsgaremek)
        //1.a Adatok menüpont kiválasztására jelenjenek meg: InitializeAsync
        public override Task InitializeAsync()
        {
            return base.InitializeAsync();
        }
    }
}
