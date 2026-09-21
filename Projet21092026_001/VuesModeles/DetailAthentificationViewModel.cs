using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Projet21092026_001.VuesModeles
{
    public partial class DetailAthentificationViewModel : ObservableObject, IQueryAttributable
    {
        #region Attributs

        [ObservableProperty]
        private string username = string.Empty;

        [ObservableProperty]
        private string message = string.Empty;

        #endregion

        #region Getters/Setters

        // Les propriétés Username et Message sont générées
        // grâce aux attributs [ObservableProperty].

        #endregion

        #region Méthodes

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            Username = query.TryGetValue("username", out object? value)
                ? value?.ToString() ?? string.Empty
                : string.Empty;

            Message = string.Equals(Username, "User", StringComparison.Ordinal)
                ? $"Bienvenue {Username}"
                : "Vous n'êtes pas authentifié";
        }

        [RelayCommand]
        private async Task Retour()
        {
            await Shell.Current.GoToAsync("..");
        }

        #endregion
    }
}
