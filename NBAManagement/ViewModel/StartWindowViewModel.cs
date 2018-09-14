using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Documents;
using System.Windows.Input;
using NBAManagement.Model;
using NBAManagement.View;

namespace NBAManagement.ViewModel
{
    public class StartWindowViewModel
    {
        public ObservableCollection<byte[]> CollectionOfImages { get; set; } = new ObservableCollection<byte[]>();

        public string AboutCurrentSeason { get; set; } =
            $"The current season is {DateTime.Now.Year - 1}-{DateTime.Now.Year}, and the NBA already has a history of {DateTime.Now.Year - 1946} years";

        List<Pictures> listImages;
        public ICommand MoveLeftClickCommand { get; set; }
        public ICommand MoveRightClickCommand { get; set; } 
        public ICommand OpenVisitorForm { get; set; }
        int index = 0;
        public StartWindowViewModel()
        {
            MoveLeftClickCommand = new Command(a => MoveLeftClick());
            MoveRightClickCommand = new Command(r => MoveRightClick());
            OpenVisitorForm = new Command(r => OpenVisitorFormView());
            listImages = App.Session.Db.Pictures.ToList();
            ShowImages(0);
        }

        void OpenVisitorFormView()
        {
            var view = new VisitorWindowView
            {
                DataContext = new VisitorWindowViewModel()
            };
            view.Show();
        }

        void MoveRightClick()
        {
            if (index <= listImages.Count - 3)
                index += 3;
            ShowImages(index);
        }

        void MoveLeftClick()
        {
            if (index >= 3)
                index -= 3;
            ShowImages(index);
        }

        void ShowImages(int startIndex)
        {
            CollectionOfImages.Clear();
            var list = listImages.Skip(startIndex).Take(3);
            foreach (var img in list)
                CollectionOfImages.Add(img.Img);
        }
    }
}
