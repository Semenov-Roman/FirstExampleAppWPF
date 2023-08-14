using System.ComponentModel;
using ReactiveUI;

namespace FirstExampleAppWPF.ViewModels;

public class ViewModelBase : ReactiveObject
{
    public event PropertyChangedEventHandler? _propertyChanged;
    
    protected  void OnPropertyChanged(string propertyName = null)
    {
        _propertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}