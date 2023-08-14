using FirstExampleAppWPF.ViewModels;

namespace FirstExampleAppWPF.MyModels;

public class Person : ViewModelBase
{
    public string Name { get; set; }

    public int Age { get; set; }

    public AddressInfo Address { get; set; }
}

public class AddressInfo : ViewModelBase
{
    public string Street { get; set; }

    public int Number { get; set; }

    private int _apartament;

    public int Apartament
    {
        get => _apartament;
        set
        {
            _apartament = value;
            OnPropertyChanged(nameof(Apartament));
        }
    }

}