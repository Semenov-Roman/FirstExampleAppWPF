using System.Collections.ObjectModel;
using FirstExampleAppWPF.MyModels;

namespace FirstExampleAppWPF.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Person> Persons { get; set; } = new(DataBase.GetPerson());

    public Person SelectedPerson { get; set; }
}