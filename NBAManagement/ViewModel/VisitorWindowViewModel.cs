using System.Windows.Input;
using NBAManagement.View;

namespace NBAManagement.ViewModel
{
    public class VisitorWindowViewModel
    {
        public ICommand OpenTeamsForm { get; set; }
        public VisitorWindowViewModel()
        {
            OpenTeamsForm = new Command(r => OpenTeamsFormView());
        }

        void OpenTeamsFormView()
        {
            var view = new TeamsWindowsView
            {
                DataContext = new TeamsWindowViewModel()
            };
            view.Show();
        }
    }
}
