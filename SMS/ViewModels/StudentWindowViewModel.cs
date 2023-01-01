using SMS.Models;
using System.ComponentModel;

namespace SMS.ViewModels
{
    public class StudentWindowViewModel : INotifyPropertyChanged
    {
        public string Name = "Jeremy Fedricks";
        public Student Student { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
