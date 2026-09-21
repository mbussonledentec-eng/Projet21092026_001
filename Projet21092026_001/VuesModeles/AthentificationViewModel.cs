using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Projet21092026_001.VuesModeles
{
    public partial class AthentificationViewModel : ObservableObject
    {
        #region Attributs

        [ObservableProperty]
        private string username;

        #endregion

        #region Constructeurs

        public AthentificationViewModel()
        {
            Username = string.Empty;
        }

        #endregion

        #region Getters/Setters

        // La propriété Username est générée automatiquement
        // grâce à [ObservableProperty].

        #endregion

        #region Méthodes

        [RelayCommand]
        private async Task Valider(string username)
        {
            Dictionary<string, object> parameters =
                new Dictionary<string, object>();

            parameters.Add("username", username);

            await Shell.Current.GoToAsync(
                "DetailAthentificationPage",
                parameters
            );
        }

        #endregion
    }
}
