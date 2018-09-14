using System.Windows;
using NBAManagement.ViewModel;

namespace NBAManagement
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Session Session { get; set; } 
        public App()
        {      
            Session = new Session();    
            var view = new StartWindowView
            {
                DataContext = new StartWindowViewModel()
            };
            view.Show();
        }
    }
}
