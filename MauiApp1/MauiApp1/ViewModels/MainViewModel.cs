using MauiApp1.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            Text = "Hello";

            People = new ObservableCollection<Person>();

            People.Add(new Person("a", 1));
            People.Add(new Person("b", 2));
            People.Add(new Person("c", 3));
            People.Add(new Person("d", 4));

        }

        private string text;

        public string Text
        {
            get => text;
            set
            {
                if (text != value)
                {
                    text = value;
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get => _people;
            set
            {
                if (_people != value)
                {
                    _people = value;
                    OnPropertyChanged(nameof(People));
                }
            }
        }

        public void AddPerson(string name, int age)
        {
            _people.Add(new Person(name, age));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
